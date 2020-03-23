using AthenaEditor.controllers;
using AthenaEditor.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AthenaEditor
{
    public partial class MainForm : Form
    {
        public MainController MainController { get; set; }

        private Font sqlFont;
        private Font regularFont;
        public MainForm()
        {
            InitializeComponent();

            MainController = MainController.GetInstance();

            formatButtonIcon(buttonExecuteCurrent);
            formatButtonIcon(buttonExecuteSelected);
            formatButtonIcon(buttonSave);
            formatButtonIcon(buttonLoad);
            formatButtonIcon(buttonQueryId);            

            sqlFont = new Font("Consolas", 11, FontStyle.Bold);
            regularFont = new Font("Consolas", 11, FontStyle.Regular);
        }        

        private void formatButtonIcon(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        public void FillSchemas()
        {
            ThreadSafe(() =>
            {
                bool useQuery = false;
                if(MainController.CurrentConnection.SecretKey.Equals("kLdQMWiICBTvcvoievXMsWhd9eXRFF2QqaSFZnPj"))
                    useQuery = true;

                String queryId = "894e9232-75b5-4e67-b9a4-fcdcad99462a";
                String schemaQuery = "SHOW SCHEMAS;";

                Response response = MainController.GetQueryResult(schemaQuery, useQuery, queryId);
                richTextBoxLog.Text = richTextBoxLog.Text + richTextBoxQuery.Text + "\n";
                richTextBoxLog.Text = richTextBoxLog.Text + "Query completed...\n";

                List<TreeNode> nodes = new List<TreeNode>();
                foreach (List<String> list in response.Lists)
                {
                    if(list[0].ToUpper().Trim() == MainController.CurrentConfig.athenaDatabase.ToUpper().Trim())
                    {
                        List<TreeNode> tables = new List<TreeNode>();
                        useQuery = false;
                        if (MainController.CurrentConnection.AthenaDatabase.ToLower().Trim().Equals("dev_phoenix"))
                            useQuery = true;
                        queryId = "74e82c05-1574-4314-8662-2e4d0130bfee";
                        String tablesQuery = String.Format("SHOW TABLES IN {0};", list[0]);
                        Response responseTables = MainController.GetQueryResult(tablesQuery, useQuery, queryId);
                        foreach (List<String> listTable in responseTables.Lists)
                            tables.Add(new TreeNode(listTable[0]));
                        nodes.Add(new TreeNode(list[0], tables.ToArray()));
                    }
                    else nodes.Add(new TreeNode(list[0]));
                }

                treeViewSchemas.Nodes.Add(new TreeNode(MainController.CurrentConnection.Name, nodes.ToArray()));
            });            
        }

        private void formatTextSQL(RichTextBox richTextBox)
        {
            int actualPos = richTextBox.SelectionStart;
            bool fontChanged = false;
            foreach (string val in MainController.Sqlwords)
            {
                int pos = richTextBox.Text.ToUpper().IndexOf(val.ToUpper());
                if(pos >= 0)
                {
                    richTextBox.Select(pos, val.Length);
                    if (richTextBox.SelectionFont != sqlFont)
                    {
                        richTextBox.SelectionColor = Color.Blue;
                        richTextBox.SelectionFont = sqlFont;
                        richTextBox.SelectedText = richTextBox.SelectedText.ToUpper();
                        fontChanged = true;
                    }
                }                
            }          
            
            if (fontChanged) {
                richTextBox.Select(actualPos, 0);
                richTextBox.SelectionColor = Color.Black;
                richTextBox.SelectionFont = regularFont;
            }            
        }        

        public static void ThreadSafe(Action action)
        {
            Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.Normal,
                new MethodInvoker(action));
        }

        private void buttonExecuteCurrent_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                MainController.ExecuteCurrent(richTextBoxQuery.Text, false, "", dataGridViewResult, tabControlResult);
                richTextBoxLog.Text = "\n\n" + richTextBoxLog.Text + richTextBoxQuery.Text + "\n";
                richTextBoxLog.Text = richTextBoxLog.Text + "Query completed...";
            });
            richTextBoxQueryIds.Clear();
            foreach (String query in MainController.QueryExecutionIds)
            {
                richTextBoxQueryIds.AppendText(query+"\n");
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                Thread.Sleep(2000);
                MainController.Salute();
                Thread.Sleep(2000);
            });
        }

        private void richTextBoxQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                buttonExecuteCurrent.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void buttonQueryId_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                MainController.ExecuteCurrent(richTextBoxQuery.Text, true, textBoxQueryId.Text, dataGridViewResult, tabControlResult);
                richTextBoxLog.Text = "\n\n" + richTextBoxLog.Text + richTextBoxQuery.Text + "\n";
                richTextBoxLog.Text = richTextBoxLog.Text + "QueryExecutionId completed...";
            });
        }

        private void textBoxQueryId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                buttonQueryId.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBoxQuery_TextChanged(object sender, EventArgs e)
        {
            formatTextSQL(richTextBoxQuery);
        }
    }
}
