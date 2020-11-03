using AthenaEditor.controllers;
using AthenaEditor.entities;
using AthenaEditor.util;
using FastColoredTextBoxNS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AthenaEditor
{
    public partial class MainForm : Form
    {
        private string lang = "CSharp (custom highlighter)";
        
        //styles
        private TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        private TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        private TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        private TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        private TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        private TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        private TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        private MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));
        public MainController MainController { get; set; }

        private Response currentResponse;
        public MainForm()
        {
            InitializeComponent();

            MainController = MainController.GetInstance();

            formatButtonIcon(buttonExecuteCurrent);
            formatButtonIcon(buttonExecuteSelected);
            formatButtonIcon(buttonSave);
            formatButtonIcon(buttonLoad);
            formatButtonIcon(buttonQueryId);
            formatButtonIcon(buttonAddTab);
            formatButtonIcon(buttonReloadConnections);
            formatButtonIcon(buttonCancelQuery);
            loadTabPages();
        }

        private void loadTabPages()
        {
            bool firstTabSet = false;
            foreach(KeyValuePair<string, string> entry in MainController.TabPageQueries)
            {
                if (!firstTabSet)
                {
                    tabQuery.Text = entry.Key;
                    fastRichTextBoxQuery.Text = entry.Value;
                    firstTabSet = true;
                }
                else addNewPageTab(entry.Key);                
            }
            tabControlQuery.SelectedIndex = 0;
        }

        private TabPage addNewPageTab(string name)
        {
            TabPage newPage = new TabPage(name);
            newPage.Location = new Point(4, 22);
            newPage.Name = String.Format("tabQuery{0}", tabControlQuery.TabPages.Count + 1);
            newPage.Padding = new Padding(3);
            newPage.Size = new Size(584, 176);
            newPage.TabIndex = 0;
            newPage.UseVisualStyleBackColor = true;
            tabControlQuery.TabPages.Add(newPage);
            return newPage;
        }

        private void formatButtonIcon(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void formatTreeViewSchemas(TreeView treeView)
        {
            ImageList imagelist = new ImageList();
            imagelist.Images.Add(Image.FromFile(Path.Combine(MainController.RelativePath, "icons\\empty.png")));
            imagelist.Images.Add(Image.FromFile(Path.Combine(MainController.RelativePath, "icons\\database.png")));
            imagelist.Images.Add(Image.FromFile(Path.Combine(MainController.RelativePath, "icons\\icons8-data-grid-16.png")));
            imagelist.Images.Add(Image.FromFile(Path.Combine(MainController.RelativePath, "icons\\type.png")));
            imagelist.Images.Add(Image.FromFile(Path.Combine(MainController.RelativePath, "icons\\databaseOk.png")));

            treeView.ImageList = imagelist;
        }

        public void FillSchemas()
        {
            labelConnection.Text = MainController.CurrentConnection.Name;
            formatTreeViewSchemas(treeViewSchemas);

            LoadSchemaInfo(true);
        }

        public static void ThreadSafe(Action action)
        {
            Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.Normal,
                new MethodInvoker(action));
        }

        private void buttonExecuteCurrent_Click(object sender, EventArgs e)
        {
            ExecuteQuery();
        }

        private void buttonQueryId_Click(object sender, EventArgs e)
        {
            ExecuteQueryExecutionId();
        }

        private void textBoxQueryId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                buttonQueryId.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void treeViewSchemas_DoubleClick(object sender, EventArgs e)
        {
            if (treeViewSchemas.SelectedNode != null && treeViewSchemas.SelectedNode.Level == 2)
            {
                fastRichTextBoxQuery.SelectionLength = 0;
                fastRichTextBoxQuery.SelectedText = treeViewSchemas.SelectedNode.Text;
            }
        }

        #region query texts
        private void AuntoIndent(AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            //some statements: case, default
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }

        private void fastRichTextBoxQuery_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            AuntoIndent(args);
        }

        private void fastRichTextBoxQuery_CustomAction(object sender, CustomActionEventArgs e)
        {
            MessageBox.Show(e.Action.ToString());
        }

        private void SelectionChangedDelayed(FastColoredTextBox textBox)
        {
            textBox.VisibleRange.ClearStyle(SameWordsStyle);
            if (!textBox.Selection.IsEmpty)
                return;//user selected diapason

            //get fragment around caret
            var fragment = textBox.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            var ranges = textBox.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
            if (ranges.Length > 1)
                foreach (var r in ranges)
                    r.SetStyle(SameWordsStyle);
        }
        private void fastRichTextBoxQuery_SelectionChangedDelayed(object sender, EventArgs e)
        {
            SelectionChangedDelayed(fastRichTextBoxQuery);
        }

        private void InitStylesPriority(FastColoredTextBox textBox)
        {
            //add this style explicitly for drawing under other styles
            textBox.AddStyle(SameWordsStyle);
        }

        private void CSharpSyntaxHighlight(FastColoredTextBox textBox, TextChangedEventArgs e)
        {
            textBox.LeftBracket = '(';
            textBox.RightBracket = ')';
            textBox.LeftBracket2 = '\x0';
            textBox.RightBracket2 = '\x0';
            //clear style of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle);

            //string highlighting
            e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            //comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            //number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            //attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            //class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");
            //keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();

            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");//allow to collapse #region blocks
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }

        private void TextChange(FastColoredTextBox textBox, TextChangedEventArgs e)
        {
            switch (lang)
            {
                case "CSharp (custom highlighter)":
                    //For sample, we will highlight the syntax of C# manually, although could use built-in highlighter
                    CSharpSyntaxHighlight(textBox, e);//custom highlighting
                    break;
                default:
                    break;//for highlighting of other languages, we using built-in FastColoredTextBox highlighter
            }

            if (textBox.Text.Trim().StartsWith("<?xml"))
            {
                textBox.Language = Language.XML;

                textBox.ClearStylesBuffer();
                textBox.Range.ClearStyle(StyleIndex.All);
                InitStylesPriority(textBox);
                textBox.AutoIndentNeeded -= fastRichTextBoxQuery_AutoIndentNeeded;

                textBox.OnSyntaxHighlight(new TextChangedEventArgs(textBox.Range));
            }
        }
        private void fastRichTextBoxQuery_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChange(fastRichTextBoxQuery, e);
        }

        private void fastRichTextBoxLog_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            AuntoIndent(args);
        }

        private void fastRichTextBoxLog_SelectionChangedDelayed(object sender, EventArgs e)
        {
            SelectionChangedDelayed(fastRichTextBoxLog);
        }

        private void fastRichTextBoxLog_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChange(fastRichTextBoxLog, e);
        }
        #endregion

        private void fastRichTextBoxQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                buttonExecuteCurrent.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void fastRichTextBoxQuery_SelectionChanged(object sender, EventArgs e)
        {
            int postition = fastRichTextBoxQuery.SelectionStart + fastRichTextBoxQuery.SelectionLength;
            int line = 1;
            for (; line < fastRichTextBoxQuery.LinesCount && postition > fastRichTextBoxQuery.GetLineLength(line - 1); line++)
                postition = postition - fastRichTextBoxQuery.GetLineLength(line - 1) - 2;

            toolStripStatusLabelLnCol.Text = " Ln: " + line + " Col: " + postition;
        }

        private void EnableButtons(bool status)
        {
            buttonExecuteCurrent.Enabled = status;
            buttonQueryId.Enabled = status;
        }

        private void ExecuteQuery()
        {
            if (!backgroundWorkerQueries.IsBusy)
            {
                toolStripProgressBar.Value = 10;
                EnableButtons(false);

                String query = Regex.Replace(fastRichTextBoxQuery.Text.Split(';')[0].Replace("\r\n", " "), @"\s+", " ");
                fastRichTextBoxLog.Text = fastRichTextBoxLog.Text + query + "\n";

                backgroundWorkerQueries.RunWorkerAsync(fastRichTextBoxQuery.Text.Split(';')[0]);
                backgroundWorkerBar.RunWorkerAsync(1);
            }
        }

        private void StopQuery()
        {
            if (!backgroundWorkerStop.IsBusy)
            {
                EnableButtons(false);

                fastRichTextBoxLog.Text = fastRichTextBoxLog.Text + "Stopping query execution Id: " + MainController.CurrentQEId + "\n";

                backgroundWorkerStop.RunWorkerAsync(MainController.CurrentQEId);                
            }
        }

        private void GetQueryResult(String query, bool useQueryExecutionId, String queryExecutionId)
        {
            try
            {
                currentResponse = MainController.GetQueryResult(query, useQueryExecutionId, queryExecutionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TextConstants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private void GetStopQuery(String queryExecutionId)
        {
            try
            {
                currentResponse = MainController.GetStopQuery(queryExecutionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TextConstants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private void backgroundWorkerQueries_DoWork(object sender, DoWorkEventArgs e)
        {
            String query = (String)e.Argument;
            GetQueryResult(query, false, "");
        }

        private void formatResponse()
        {
            if (currentResponse.Status.Equals("SUCCEEDED"))
            {
                TabPage tabPage = tabControlResult.TabPages[0];
                tabPage.Text = String.Format("Result #{0} ({1}x{2})", 1, currentResponse.Lists[0].Count, currentResponse.Lists.Count - 1);

                dataGridViewResult.Columns.Clear();
                foreach (String header in currentResponse.Lists[0])
                    dataGridViewResult.Columns.Add(header, header.Replace(" ", "_"));
                for (int i = 0; i < currentResponse.Lists.Count - 1; i++)
                    dataGridViewResult.Rows.Insert(i, currentResponse.Lists[i + 1].ToArray());


                fastRichTextBoxLog.Text = fastRichTextBoxLog.Text + String.Format("#Query completed: {0} secs. - Query Execution Id: {1}\n",
                    (float)currentResponse.Duration / 1000f, currentResponse.QueryExecutionId);
                MainController.QueryExecutionIds.Add(currentResponse.QueryExecutionId);
            }
            else
            {
                String meesage = Regex.Replace(currentResponse.Message.Replace("\r\n", " "), @"\s+", " ");
                fastRichTextBoxLog.Text = fastRichTextBoxLog.Text + String.Format("Query failed: {0}\n", meesage);
            }
            richTextBoxQueryIds.Clear();
            foreach (String queryId in MainController.QueryExecutionIds)
            {
                richTextBoxQueryIds.AppendText(queryId + "\n");
            }
        }

        private void backgroundWorkerQueries_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formatResponse();
            toolStripProgressBar.Value = 100;
            EnableButtons(true);
        }

        private void ExecuteQueryExecutionId()
        {
            if (!backgroundWorkerQueryId.IsBusy)
            {
                toolStripProgressBar.Value = 10;
                EnableButtons(false);

                backgroundWorkerQueryId.RunWorkerAsync(textBoxQueryId.Text);
                backgroundWorkerBar.RunWorkerAsync(2);
            }
        }

        private void backgroundWorkerQueryId_DoWork(object sender, DoWorkEventArgs e)
        {
            String queryId = (String)e.Argument;
            GetQueryResult("", true, queryId);
        }

        private void backgroundWorkerQueryId_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formatResponse();
            toolStripProgressBar.Value = 100;
            EnableButtons(true);
        }

        private void backgroundWorkerBar_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorkerBar.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            int progress = (int)e.Argument;
            for (int i = 10; i < 95; i += 5 * progress)
            {
                backgroundWorkerBar.ReportProgress(i);
                Thread.Sleep(100 * progress);
            }
        }

        private void backgroundWorkerBar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerBar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar.Value = 100;
        }

        private void LoadSchemaInfo(bool useQueryExecutionId)
        {
            if (!backgroundWorkerSchemaInfo.IsBusy)
            {
                toolStripProgressBar.Value = 10;
                fastRichTextBoxLog.Text = fastRichTextBoxLog.Text + TextConstants.QueryInfoSchema + "\n";
                EnableButtons(false);

                backgroundWorkerSchemaInfo.RunWorkerAsync(useQueryExecutionId && MainController.CurrentConnection.QueryExecutionIdSchemaInfo.Length == 36 ? 
                    MainController.CurrentConnection.QueryExecutionIdSchemaInfo : TextConstants.QueryInfoSchema);
                backgroundWorkerBar.RunWorkerAsync(useQueryExecutionId ? 2 : 1);
            }
        }

        private void backgroundWorkerSchemaInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            String query = (String)e.Argument;
            bool useQueryExcutionId = query.Length == 36;
            GetQueryResult(query, useQueryExcutionId, query);
        }

        private void FormatSchemaInfo()
        {
            try
            {
                if (currentResponse.Status.Equals("SUCCEEDED"))
                {
                    MainController.SchemasInfo.Clear();
                    // starting second line to ignore the headers
                    for (int i = 1; i < currentResponse.Lists.Count; i++)
                    {
                        string tableSchema = currentResponse.Lists[i][0];
                        string tableName = currentResponse.Lists[i][1];
                        string columnName = currentResponse.Lists[i][2];
                        int ordinalPosition = int.Parse(currentResponse.Lists[i][3]);
                        string isNullable = currentResponse.Lists[i][4];
                        string dataType = currentResponse.Lists[i][5];
                        string comment = currentResponse.Lists[i][6];
                        string extraInfo = currentResponse.Lists[i][7];

                        if (!MainController.SchemasInfo.ContainsKey(tableSchema))
                            MainController.SchemasInfo.Add(tableSchema, new SchemaInfo(tableSchema, new Dictionary<string, TableInfo>()));

                        if (!MainController.SchemasInfo[tableSchema].Tables.ContainsKey(tableName))
                            MainController.SchemasInfo[tableSchema].Tables.Add(tableName, new TableInfo(tableName, new Dictionary<string, ColumnInfo>()));

                        MainController.SchemasInfo[tableSchema].Tables[tableName].Columns
                                .Add(columnName, new ColumnInfo(columnName, ordinalPosition, isNullable, dataType, comment, extraInfo));

                    }

                    fastRichTextBoxLog.Text = fastRichTextBoxLog.Text + String.Format("#Query completed: {0} secs. - Query Execution Id: {1}\n",
                        (float)currentResponse.Duration / 1000f, currentResponse.QueryExecutionId);
                    MainController.QueryExecutionIds.Add(currentResponse.QueryExecutionId);

                    // update conections schema query id
                    if (!MainController.CurrentConnection.QueryExecutionIdSchemaInfo.Equals(currentResponse.QueryExecutionId, StringComparison.CurrentCulture))
                    {
                        MainController.CurrentConnection.QueryExecutionIdSchemaInfo = currentResponse.QueryExecutionId;
                        MainController.Connections
                            .Where(a => a.Name == MainController.CurrentConnection.Name)
                            .Select(c => MainController.CurrentConnection).ToList();
                        MainController.SaveConnectionsIntoFile();
                    }
                }

                treeViewSchemas.Nodes.Clear();
                List<TreeNode> shemaNodes = new List<TreeNode>();
                foreach (KeyValuePair<string, SchemaInfo> schema in MainController.SchemasInfo)
                {
                    List<TreeNode> tableNodes = new List<TreeNode>();
                    foreach (KeyValuePair<string, TableInfo> table in schema.Value.Tables)
                    {
                        List<TreeNode> columnNodes = new List<TreeNode>();
                        foreach (KeyValuePair<string, ColumnInfo> column in table.Value.Columns)
                            columnNodes.Add(new TreeNode(column.Key, 3, 3));
                        tableNodes.Add(new TreeNode(table.Key, 2, 2, columnNodes.ToArray()));
                    }
                    if (schema.Key.Equals(MainController.CurrentConnection.AthenaDatabase, StringComparison.OrdinalIgnoreCase))
                        shemaNodes.Add(new TreeNode(schema.Key, 4, 4, tableNodes.ToArray()));
                    else shemaNodes.Add(new TreeNode(schema.Key, 1, 1, tableNodes.ToArray()));
                }
                TreeNode mainNode = new TreeNode("", 0, 0, shemaNodes.ToArray());
                mainNode.Expand();
                treeViewSchemas.Nodes.Add(mainNode);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void backgroundWorkerSchemaInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormatSchemaInfo();
            backgroundWorkerBar.CancelAsync();
            toolStripProgressBar.Value = 0;
            EnableButtons(true);            
        }
        private void treeViewSchemas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBoxNames.Items.Clear();
            if (treeViewSchemas.SelectedNode != null)
            {
                if (treeViewSchemas.SelectedNode.Level == 1)
                {
                    labelType.Text = "Schema:";
                    listBoxNames.Items.AddRange(new object[] {
                        String.Format("Tables:    {0}",
                        MainController.SchemasInfo[treeViewSchemas.SelectedNode.Text].Tables.Count)});
                }
                else if (treeViewSchemas.SelectedNode.Level == 2)
                {
                    labelType.Text = "Table:";
                    List<String> items = new List<string>();
                    foreach (KeyValuePair<string, ColumnInfo> column in MainController.SchemasInfo[treeViewSchemas.SelectedNode.Parent.Text]
                            .Tables[treeViewSchemas.SelectedNode.Text].Columns)
                    {
                        items.Add(String.Format("{0}:  {1}", column.Key, column.Value.DataType));
                    }
                    listBoxNames.Items.AddRange(items.ToArray());
                }
                else if (treeViewSchemas.SelectedNode.Level == 3)
                {
                    labelType.Text = "Column:";
                    ColumnInfo column = MainController.SchemasInfo[treeViewSchemas.SelectedNode.Parent.Parent.Text]
                            .Tables[treeViewSchemas.SelectedNode.Parent.Text].Columns[treeViewSchemas.SelectedNode.Text];

                    listBoxNames.Items.AddRange(new object[] {
                        String.Format("order:      {0}", column.OrdinalPosition),
                        String.Format("nullalbe:   {0}", column.IsNullable),
                        String.Format("data type:  {0}", column.DataType),
                        String.Format("comment:    {0}", column.Comment),
                        String.Format("extra info: {0}", column.ExtraInfo),
                    });
                }
                labelName.Text = treeViewSchemas.SelectedNode.Text;
            }
        }

        // add query
        private void buttonAddTab_Click(object sender, EventArgs e)
        {
            tabControlQuery.SelectTab(addNewPageTab(String.Format("Query #{0}", tabControlQuery.TabPages.Count + 1)));
        }
        private void tabControlQuery_Selected(object sender, TabControlEventArgs e)
        {
            if(MainController.TabPageQueries.ContainsKey(e.TabPage.Text))
                fastRichTextBoxQuery.Text = MainController.TabPageQueries[e.TabPage.Text];
            else
            {
                fastRichTextBoxQuery.Text = "";
                MainController.TabPageQueries.Add(e.TabPage.Text, "");
            }
            tabControlQuery.SelectedTab.Controls.Add(fastRichTextBoxQuery);
        }
        private void tabControlQuery_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            Console.WriteLine("Before: " + e.TabPage.Text);
            if (MainController.TabPageQueries.ContainsKey(e.TabPage.Text))
                MainController.TabPageQueries[e.TabPage.Text] = fastRichTextBoxQuery.Text;
            else MainController.TabPageQueries.Add(e.TabPage.Text, fastRichTextBoxQuery.Text);
        }

        // save sql
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "SQL file|*.sql";
            saveFileDialog1.Title = "Save an SQL File";
            saveFileDialog1.ShowDialog();

            if (!saveFileDialog1.FileName.Equals(""))
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        try
                        {
                            // save the sql query
                            byte[] bytes = Encoding.UTF8.GetBytes(fastRichTextBoxQuery.Text);
                            fs.Write(bytes, 0, bytes.Length);

                            // update conections file
                            MainController.CurrentConnection.TabQueries.Add(fs.Name);
                            MainController.Connections
                                .Where(a => a.Name == MainController.CurrentConnection.Name)
                                .Select(c => MainController.CurrentConnection).ToList();                            
                            MainController.SaveConnectionsIntoFile();
                            
                            string oldName = tabControlQuery.SelectedTab.Text;
                            tabControlQuery.SelectedTab.Text = Path.GetFileName(fs.Name).ToLower(CultureInfo.CurrentCulture).Replace(".sql", "");
                            Util.RenameKey(MainController.TabPageQueries, oldName, tabControlQuery.SelectedTab.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, TextConstants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }

                fs.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SQL file|*.sql";
            openFileDialog1.Title = "Open an SQL File";
            openFileDialog1.ShowDialog();

            if (!openFileDialog1.FileName.Equals(""))
            {
                FileStream fs = (FileStream)openFileDialog1.OpenFile();
                string fileContents;
                using (StreamReader reader = new StreamReader(fs))
                {
                    fileContents = reader.ReadToEnd();
                }

                // update conections file
                String nameQuery = Path.GetFileName(fs.Name).ToLower(CultureInfo.CurrentCulture).Replace(".sql", "");
                MainController.CurrentConnection.TabQueries.Add(fs.Name);
                MainController.TabPageQueries.Add(nameQuery, fileContents);
                MainController.SaveConnectionsIntoFile();
                tabControlQuery.SelectTab(addNewPageTab(nameQuery));

                fs.Close();
            }
        }

        private void buttonReloadConnections_Click(object sender, EventArgs e)
        {
            LoadSchemaInfo(false);            
        }

        private void buttonCancelQuery_Click(object sender, EventArgs e)
        {
            StopQuery();
        }

        private void buttonExecuteSelected_Click(object sender, EventArgs e)
        {
            Config config = new Config("sampledb", "s3://test-with-athena/my-bucket/", 1000,
                    "AKIAICOANOWN5KXOXOUA", "kOJJ3/qHXb7UI9C8DYHVDsZLXfheNYhd7bMJ110F",
                    "US_EAST_2", false);
            config.queries.Add("show databases");
            config.useQueryId = false;

            String json = JsonConvert.SerializeObject(config);

            using (var socket = new TcpClient("127.0.0.1", 8081))
            {
                var headerContent = new StringBuilder();
                headerContent.AppendLine("POST /athena-api/execute-stream HTTP/1.0");
                headerContent.AppendLine("Accept: */*");
                headerContent.AppendLine("Host: " + 8081);
                headerContent.AppendLine("Content-Type: application/json");
                headerContent.AppendLine("Content-Length: " + json.Length);
                headerContent.AppendLine("Connection: keep-alive");
                headerContent.AppendLine();

                var header = Encoding.UTF8.GetBytes(headerContent.ToString());
                var body = Encoding.UTF8.GetBytes(json);

                using (var stream = socket.GetStream())
                {
                    stream.Write(header, 0, header.Length);
                    stream.Write(body, 0, body.Length);

                    stream.Flush();

                    // Process the response.
                    StreamReader rdr = new StreamReader(stream);

                    while (!rdr.EndOfStream)
                    {
                        Console.WriteLine(rdr.ReadLine());
                    }
                }
            }
            
        }

        private void backgroundWorkerStop_DoWork(object sender, DoWorkEventArgs e)
        {
            String query = (String)e.Argument;
            GetStopQuery(query);
        }

        private void backgroundWorkerStop_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableButtons(true);
        }
    }
}
