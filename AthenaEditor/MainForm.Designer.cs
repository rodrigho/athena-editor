namespace AthenaEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelSchema = new System.Windows.Forms.Panel();
            this.splitContainerSchema = new System.Windows.Forms.SplitContainer();
            this.treeViewSchemas = new System.Windows.Forms.TreeView();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelConnection = new System.Windows.Forms.Label();
            this.labelSchemas = new System.Windows.Forms.Label();
            this.splitContainerWorkspace = new System.Windows.Forms.SplitContainer();
            this.splitContainerQuery = new System.Windows.Forms.SplitContainer();
            this.tabControlQuery = new System.Windows.Forms.TabControl();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.fastRichTextBoxQuery = new FastColoredTextBoxNS.FastColoredTextBox();
            this.richTextBoxQueryIds = new System.Windows.Forms.RichTextBox();
            this.tabControlResult = new System.Windows.Forms.TabControl();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLnCol = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerLog = new System.Windows.Forms.SplitContainer();
            this.fastRichTextBoxLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.backgroundWorkerQueries = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerQueryId = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerBar = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSchemaInfo = new System.ComponentModel.BackgroundWorker();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExecuteSelected = new System.Windows.Forms.Button();
            this.buttonExecuteCurrent = new System.Windows.Forms.Button();
            this.labelQueryId = new System.Windows.Forms.Label();
            this.textBoxQueryId = new System.Windows.Forms.TextBox();
            this.buttonQueryId = new System.Windows.Forms.Button();
            this.buttonAddTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancelQuery = new System.Windows.Forms.Button();
            this.buttonReloadConnections = new System.Windows.Forms.Button();
            this.backgroundWorkerStop = new System.ComponentModel.BackgroundWorker();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSchema)).BeginInit();
            this.splitContainerSchema.Panel1.SuspendLayout();
            this.splitContainerSchema.Panel2.SuspendLayout();
            this.splitContainerSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkspace)).BeginInit();
            this.splitContainerWorkspace.Panel1.SuspendLayout();
            this.splitContainerWorkspace.Panel2.SuspendLayout();
            this.splitContainerWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuery)).BeginInit();
            this.splitContainerQuery.Panel1.SuspendLayout();
            this.splitContainerQuery.Panel2.SuspendLayout();
            this.splitContainerQuery.SuspendLayout();
            this.tabControlQuery.SuspendLayout();
            this.tabQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastRichTextBoxQuery)).BeginInit();
            this.tabControlResult.SuspendLayout();
            this.tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLog)).BeginInit();
            this.splitContainerLog.Panel1.SuspendLayout();
            this.splitContainerLog.Panel2.SuspendLayout();
            this.splitContainerLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastRichTextBoxLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1028, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConectionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addConectionToolStripMenuItem
            // 
            this.addConectionToolStripMenuItem.Name = "addConectionToolStripMenuItem";
            this.addConectionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addConectionToolStripMenuItem.Text = "Add Conection";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.AccessibleName = "PanelFiles";
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel1.Controls.Add(this.panelSchema);
            this.splitContainerMain.Panel1.Controls.Add(this.labelConnection);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSchemas);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AccessibleName = "PanelWorkspace";
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerWorkspace);
            this.splitContainerMain.Size = new System.Drawing.Size(1028, 383);
            this.splitContainerMain.SplitterDistance = 241;
            this.splitContainerMain.TabIndex = 2;
            // 
            // panelSchema
            // 
            this.panelSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSchema.Controls.Add(this.splitContainerSchema);
            this.panelSchema.Location = new System.Drawing.Point(0, 28);
            this.panelSchema.Name = "panelSchema";
            this.panelSchema.Size = new System.Drawing.Size(243, 352);
            this.panelSchema.TabIndex = 3;
            // 
            // splitContainerSchema
            // 
            this.splitContainerSchema.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSchema.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSchema.Name = "splitContainerSchema";
            this.splitContainerSchema.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSchema.Panel1
            // 
            this.splitContainerSchema.Panel1.Controls.Add(this.treeViewSchemas);
            // 
            // splitContainerSchema.Panel2
            // 
            this.splitContainerSchema.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainerSchema.Panel2.Controls.Add(this.listBoxNames);
            this.splitContainerSchema.Panel2.Controls.Add(this.labelName);
            this.splitContainerSchema.Panel2.Controls.Add(this.labelType);
            this.splitContainerSchema.Size = new System.Drawing.Size(243, 352);
            this.splitContainerSchema.SplitterDistance = 262;
            this.splitContainerSchema.TabIndex = 0;
            // 
            // treeViewSchemas
            // 
            this.treeViewSchemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewSchemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSchemas.Indent = 16;
            this.treeViewSchemas.Location = new System.Drawing.Point(0, 0);
            this.treeViewSchemas.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.treeViewSchemas.Name = "treeViewSchemas";
            this.treeViewSchemas.ShowRootLines = false;
            this.treeViewSchemas.Size = new System.Drawing.Size(243, 262);
            this.treeViewSchemas.TabIndex = 0;
            this.treeViewSchemas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSchemas_AfterSelect);
            this.treeViewSchemas.DoubleClick += new System.EventHandler(this.treeViewSchemas_DoubleClick);
            // 
            // listBoxNames
            // 
            this.listBoxNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.HorizontalScrollbar = true;
            this.listBoxNames.Location = new System.Drawing.Point(8, 25);
            this.listBoxNames.MultiColumn = true;
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(221, 52);
            this.listBoxNames.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(58, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "schema_name";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelType.Location = new System.Drawing.Point(4, 6);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(58, 14);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Schema:";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.ForeColor = System.Drawing.Color.Chocolate;
            this.labelConnection.Location = new System.Drawing.Point(69, 6);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(69, 15);
            this.labelConnection.TabIndex = 2;
            this.labelConnection.Text = "connection";
            // 
            // labelSchemas
            // 
            this.labelSchemas.AutoSize = true;
            this.labelSchemas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchemas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSchemas.Location = new System.Drawing.Point(4, 7);
            this.labelSchemas.Name = "labelSchemas";
            this.labelSchemas.Size = new System.Drawing.Size(60, 14);
            this.labelSchemas.TabIndex = 1;
            this.labelSchemas.Text = "Schemas";
            // 
            // splitContainerWorkspace
            // 
            this.splitContainerWorkspace.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWorkspace.Location = new System.Drawing.Point(0, 0);
            this.splitContainerWorkspace.Name = "splitContainerWorkspace";
            this.splitContainerWorkspace.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerWorkspace.Panel1
            // 
            this.splitContainerWorkspace.Panel1.Controls.Add(this.splitContainerQuery);
            // 
            // splitContainerWorkspace.Panel2
            // 
            this.splitContainerWorkspace.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerWorkspace.Panel2.Controls.Add(this.tabControlResult);
            this.splitContainerWorkspace.Size = new System.Drawing.Size(783, 383);
            this.splitContainerWorkspace.SplitterDistance = 208;
            this.splitContainerWorkspace.TabIndex = 0;
            // 
            // splitContainerQuery
            // 
            this.splitContainerQuery.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerQuery.Location = new System.Drawing.Point(0, 0);
            this.splitContainerQuery.Name = "splitContainerQuery";
            // 
            // splitContainerQuery.Panel1
            // 
            this.splitContainerQuery.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerQuery.Panel1.Controls.Add(this.tabControlQuery);
            // 
            // splitContainerQuery.Panel2
            // 
            this.splitContainerQuery.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainerQuery.Panel2.Controls.Add(this.richTextBoxQueryIds);
            this.splitContainerQuery.Size = new System.Drawing.Size(783, 208);
            this.splitContainerQuery.SplitterDistance = 595;
            this.splitContainerQuery.TabIndex = 0;
            // 
            // tabControlQuery
            // 
            this.tabControlQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlQuery.Controls.Add(this.tabQuery);
            this.tabControlQuery.Location = new System.Drawing.Point(0, 3);
            this.tabControlQuery.Name = "tabControlQuery";
            this.tabControlQuery.SelectedIndex = 0;
            this.tabControlQuery.Size = new System.Drawing.Size(592, 202);
            this.tabControlQuery.TabIndex = 0;
            this.tabControlQuery.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlQuery_Selected);
            this.tabControlQuery.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlQuery_Deselecting);
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.fastRichTextBoxQuery);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(584, 176);
            this.tabQuery.TabIndex = 0;
            this.tabQuery.Text = "Query #1";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // fastRichTextBoxQuery
            // 
            this.fastRichTextBoxQuery.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastRichTextBoxQuery.AutoIndentCharsPatterns = "";
            this.fastRichTextBoxQuery.AutoIndentExistingLines = false;
            this.fastRichTextBoxQuery.AutoScrollMinSize = new System.Drawing.Size(32, 15);
            this.fastRichTextBoxQuery.BackBrush = null;
            this.fastRichTextBoxQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastRichTextBoxQuery.CharHeight = 15;
            this.fastRichTextBoxQuery.CharWidth = 7;
            this.fastRichTextBoxQuery.CommentPrefix = "--";
            this.fastRichTextBoxQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastRichTextBoxQuery.DelayedEventsInterval = 200;
            this.fastRichTextBoxQuery.DelayedTextChangedInterval = 500;
            this.fastRichTextBoxQuery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastRichTextBoxQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastRichTextBoxQuery.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fastRichTextBoxQuery.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fastRichTextBoxQuery.IsReplaceMode = false;
            this.fastRichTextBoxQuery.Language = FastColoredTextBoxNS.Language.SQL;
            this.fastRichTextBoxQuery.LeftBracket = '(';
            this.fastRichTextBoxQuery.Location = new System.Drawing.Point(3, 3);
            this.fastRichTextBoxQuery.Name = "fastRichTextBoxQuery";
            this.fastRichTextBoxQuery.Paddings = new System.Windows.Forms.Padding(0);
            this.fastRichTextBoxQuery.PreferredLineWidth = 80;
            this.fastRichTextBoxQuery.ReservedCountOfLineNumberChars = 2;
            this.fastRichTextBoxQuery.RightBracket = ')';
            this.fastRichTextBoxQuery.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastRichTextBoxQuery.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastRichTextBoxQuery.ServiceColors")));
            this.fastRichTextBoxQuery.ServiceLinesColor = System.Drawing.Color.White;
            this.fastRichTextBoxQuery.Size = new System.Drawing.Size(578, 170);
            this.fastRichTextBoxQuery.TabIndex = 4;
            this.fastRichTextBoxQuery.Zoom = 100;
            this.fastRichTextBoxQuery.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastRichTextBoxQuery_TextChanged);
            this.fastRichTextBoxQuery.SelectionChanged += new System.EventHandler(this.fastRichTextBoxQuery_SelectionChanged);
            this.fastRichTextBoxQuery.SelectionChangedDelayed += new System.EventHandler(this.fastRichTextBoxQuery_SelectionChangedDelayed);
            this.fastRichTextBoxQuery.AutoIndentNeeded += new System.EventHandler<FastColoredTextBoxNS.AutoIndentEventArgs>(this.fastRichTextBoxQuery_AutoIndentNeeded);
            this.fastRichTextBoxQuery.CustomAction += new System.EventHandler<FastColoredTextBoxNS.CustomActionEventArgs>(this.fastRichTextBoxQuery_CustomAction);
            this.fastRichTextBoxQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fastRichTextBoxQuery_KeyDown);
            // 
            // richTextBoxQueryIds
            // 
            this.richTextBoxQueryIds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxQueryIds.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQueryIds.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBoxQueryIds.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxQueryIds.Name = "richTextBoxQueryIds";
            this.richTextBoxQueryIds.Size = new System.Drawing.Size(184, 208);
            this.richTextBoxQueryIds.TabIndex = 0;
            this.richTextBoxQueryIds.Text = "";
            // 
            // tabControlResult
            // 
            this.tabControlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlResult.Controls.Add(this.tabResult);
            this.tabControlResult.Location = new System.Drawing.Point(0, 3);
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.SelectedIndex = 0;
            this.tabControlResult.Size = new System.Drawing.Size(783, 166);
            this.tabControlResult.TabIndex = 0;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.dataGridViewResult);
            this.tabResult.Location = new System.Drawing.Point(4, 22);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult.Size = new System.Drawing.Size(775, 140);
            this.tabResult.TabIndex = 1;
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResult
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewResult.Size = new System.Drawing.Size(769, 134);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusProgress,
            this.toolStripStatusLabelLnCol});
            this.statusStrip.Location = new System.Drawing.Point(0, 508);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusProgress
            // 
            this.toolStripStatusProgress.Name = "toolStripStatusProgress";
            this.toolStripStatusProgress.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusProgress.Text = ":Progress";
            // 
            // toolStripStatusLabelLnCol
            // 
            this.toolStripStatusLabelLnCol.Name = "toolStripStatusLabelLnCol";
            this.toolStripStatusLabelLnCol.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabelLnCol.Text = "Ln: 1 Col: 10";
            // 
            // splitContainerLog
            // 
            this.splitContainerLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerLog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerLog.Location = new System.Drawing.Point(0, 52);
            this.splitContainerLog.Name = "splitContainerLog";
            this.splitContainerLog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLog.Panel1
            // 
            this.splitContainerLog.Panel1.Controls.Add(this.splitContainerMain);
            // 
            // splitContainerLog.Panel2
            // 
            this.splitContainerLog.Panel2.Controls.Add(this.fastRichTextBoxLog);
            this.splitContainerLog.Size = new System.Drawing.Size(1028, 454);
            this.splitContainerLog.SplitterDistance = 383;
            this.splitContainerLog.TabIndex = 4;
            // 
            // fastRichTextBoxLog
            // 
            this.fastRichTextBoxLog.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastRichTextBoxLog.AutoIndentCharsPatterns = "";
            this.fastRichTextBoxLog.AutoIndentExistingLines = false;
            this.fastRichTextBoxLog.AutoScrollMinSize = new System.Drawing.Size(32, 15);
            this.fastRichTextBoxLog.BackBrush = null;
            this.fastRichTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastRichTextBoxLog.CaretVisible = false;
            this.fastRichTextBoxLog.CharHeight = 15;
            this.fastRichTextBoxLog.CharWidth = 7;
            this.fastRichTextBoxLog.CommentPrefix = "--";
            this.fastRichTextBoxLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastRichTextBoxLog.DelayedEventsInterval = 200;
            this.fastRichTextBoxLog.DelayedTextChangedInterval = 500;
            this.fastRichTextBoxLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastRichTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastRichTextBoxLog.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fastRichTextBoxLog.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fastRichTextBoxLog.IsReplaceMode = false;
            this.fastRichTextBoxLog.Language = FastColoredTextBoxNS.Language.SQL;
            this.fastRichTextBoxLog.LeftBracket = '(';
            this.fastRichTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.fastRichTextBoxLog.Name = "fastRichTextBoxLog";
            this.fastRichTextBoxLog.Paddings = new System.Windows.Forms.Padding(0);
            this.fastRichTextBoxLog.PreferredLineWidth = 80;
            this.fastRichTextBoxLog.ReadOnly = true;
            this.fastRichTextBoxLog.ReservedCountOfLineNumberChars = 2;
            this.fastRichTextBoxLog.RightBracket = ')';
            this.fastRichTextBoxLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastRichTextBoxLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastRichTextBoxLog.ServiceColors")));
            this.fastRichTextBoxLog.ServiceLinesColor = System.Drawing.Color.White;
            this.fastRichTextBoxLog.Size = new System.Drawing.Size(1028, 67);
            this.fastRichTextBoxLog.TabIndex = 5;
            this.fastRichTextBoxLog.Zoom = 100;
            this.fastRichTextBoxLog.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastRichTextBoxLog_TextChanged);
            this.fastRichTextBoxLog.SelectionChangedDelayed += new System.EventHandler(this.fastRichTextBoxLog_SelectionChangedDelayed);
            this.fastRichTextBoxLog.AutoIndentNeeded += new System.EventHandler<FastColoredTextBoxNS.AutoIndentEventArgs>(this.fastRichTextBoxLog_AutoIndentNeeded);
            // 
            // backgroundWorkerQueries
            // 
            this.backgroundWorkerQueries.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQueries_DoWork);
            this.backgroundWorkerQueries.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQueries_RunWorkerCompleted);
            // 
            // backgroundWorkerQueryId
            // 
            this.backgroundWorkerQueryId.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQueryId_DoWork);
            this.backgroundWorkerQueryId.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQueryId_RunWorkerCompleted);
            // 
            // backgroundWorkerBar
            // 
            this.backgroundWorkerBar.WorkerReportsProgress = true;
            this.backgroundWorkerBar.WorkerSupportsCancellation = true;
            this.backgroundWorkerBar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBar_DoWork);
            this.backgroundWorkerBar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerBar_ProgressChanged);
            this.backgroundWorkerBar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerBar_RunWorkerCompleted);
            // 
            // backgroundWorkerSchemaInfo
            // 
            this.backgroundWorkerSchemaInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSchemaInfo_DoWork);
            this.backgroundWorkerSchemaInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSchemaInfo_RunWorkerCompleted);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
            this.buttonLoad.Location = new System.Drawing.Point(244, -1);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(23, 22);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(266, -1);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(23, 22);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExecuteSelected
            // 
            this.buttonExecuteSelected.Image = ((System.Drawing.Image)(resources.GetObject("buttonExecuteSelected.Image")));
            this.buttonExecuteSelected.Location = new System.Drawing.Point(298, -1);
            this.buttonExecuteSelected.Name = "buttonExecuteSelected";
            this.buttonExecuteSelected.Size = new System.Drawing.Size(23, 22);
            this.buttonExecuteSelected.TabIndex = 2;
            this.buttonExecuteSelected.UseVisualStyleBackColor = true;
            this.buttonExecuteSelected.Click += new System.EventHandler(this.buttonExecuteSelected_Click);
            // 
            // buttonExecuteCurrent
            // 
            this.buttonExecuteCurrent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExecuteCurrent.FlatAppearance.BorderSize = 0;
            this.buttonExecuteCurrent.Image = ((System.Drawing.Image)(resources.GetObject("buttonExecuteCurrent.Image")));
            this.buttonExecuteCurrent.Location = new System.Drawing.Point(320, -1);
            this.buttonExecuteCurrent.Name = "buttonExecuteCurrent";
            this.buttonExecuteCurrent.Size = new System.Drawing.Size(23, 22);
            this.buttonExecuteCurrent.TabIndex = 3;
            this.buttonExecuteCurrent.UseVisualStyleBackColor = false;
            this.buttonExecuteCurrent.Click += new System.EventHandler(this.buttonExecuteCurrent_Click);
            // 
            // labelQueryId
            // 
            this.labelQueryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQueryId.AutoSize = true;
            this.labelQueryId.Location = new System.Drawing.Point(522, 4);
            this.labelQueryId.Name = "labelQueryId";
            this.labelQueryId.Size = new System.Drawing.Size(100, 13);
            this.labelQueryId.TabIndex = 4;
            this.labelQueryId.Text = "Query Execution Id:";
            // 
            // textBoxQueryId
            // 
            this.textBoxQueryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQueryId.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQueryId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxQueryId.Location = new System.Drawing.Point(620, 0);
            this.textBoxQueryId.Name = "textBoxQueryId";
            this.textBoxQueryId.Size = new System.Drawing.Size(378, 19);
            this.textBoxQueryId.TabIndex = 5;
            this.textBoxQueryId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQueryId_KeyDown);
            // 
            // buttonQueryId
            // 
            this.buttonQueryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQueryId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonQueryId.FlatAppearance.BorderSize = 0;
            this.buttonQueryId.Image = ((System.Drawing.Image)(resources.GetObject("buttonQueryId.Image")));
            this.buttonQueryId.Location = new System.Drawing.Point(1000, -1);
            this.buttonQueryId.Name = "buttonQueryId";
            this.buttonQueryId.Size = new System.Drawing.Size(23, 22);
            this.buttonQueryId.TabIndex = 6;
            this.buttonQueryId.UseVisualStyleBackColor = false;
            this.buttonQueryId.Click += new System.EventHandler(this.buttonQueryId_Click);
            // 
            // buttonAddTab
            // 
            this.buttonAddTab.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddTab.Image")));
            this.buttonAddTab.Location = new System.Drawing.Point(207, -1);
            this.buttonAddTab.Name = "buttonAddTab";
            this.buttonAddTab.Size = new System.Drawing.Size(23, 22);
            this.buttonAddTab.TabIndex = 9;
            this.buttonAddTab.UseVisualStyleBackColor = true;
            this.buttonAddTab.Click += new System.EventHandler(this.buttonAddTab_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonCancelQuery);
            this.panel1.Controls.Add(this.buttonReloadConnections);
            this.panel1.Controls.Add(this.buttonAddTab);
            this.panel1.Controls.Add(this.buttonQueryId);
            this.panel1.Controls.Add(this.textBoxQueryId);
            this.panel1.Controls.Add(this.labelQueryId);
            this.panel1.Controls.Add(this.buttonExecuteCurrent);
            this.panel1.Controls.Add(this.buttonExecuteSelected);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 22);
            this.panel1.TabIndex = 1;
            // 
            // buttonCancelQuery
            // 
            this.buttonCancelQuery.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCancelQuery.FlatAppearance.BorderSize = 0;
            this.buttonCancelQuery.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelQuery.Image")));
            this.buttonCancelQuery.Location = new System.Drawing.Point(342, -1);
            this.buttonCancelQuery.Name = "buttonCancelQuery";
            this.buttonCancelQuery.Size = new System.Drawing.Size(23, 22);
            this.buttonCancelQuery.TabIndex = 11;
            this.buttonCancelQuery.UseVisualStyleBackColor = false;
            this.buttonCancelQuery.Click += new System.EventHandler(this.buttonCancelQuery_Click);
            // 
            // buttonReloadConnections
            // 
            this.buttonReloadConnections.Image = ((System.Drawing.Image)(resources.GetObject("buttonReloadConnections.Image")));
            this.buttonReloadConnections.Location = new System.Drawing.Point(2, -1);
            this.buttonReloadConnections.Name = "buttonReloadConnections";
            this.buttonReloadConnections.Size = new System.Drawing.Size(23, 22);
            this.buttonReloadConnections.TabIndex = 10;
            this.buttonReloadConnections.UseVisualStyleBackColor = true;
            this.buttonReloadConnections.Click += new System.EventHandler(this.buttonReloadConnections_Click);
            // 
            // backgroundWorkerStop
            // 
            this.backgroundWorkerStop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerStop_DoWork);
            this.backgroundWorkerStop.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerStop_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 530);
            this.Controls.Add(this.splitContainerLog);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "AthenaEditor 1.0.0";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelSchema.ResumeLayout(false);
            this.splitContainerSchema.Panel1.ResumeLayout(false);
            this.splitContainerSchema.Panel2.ResumeLayout(false);
            this.splitContainerSchema.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSchema)).EndInit();
            this.splitContainerSchema.ResumeLayout(false);
            this.splitContainerWorkspace.Panel1.ResumeLayout(false);
            this.splitContainerWorkspace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkspace)).EndInit();
            this.splitContainerWorkspace.ResumeLayout(false);
            this.splitContainerQuery.Panel1.ResumeLayout(false);
            this.splitContainerQuery.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuery)).EndInit();
            this.splitContainerQuery.ResumeLayout(false);
            this.tabControlQuery.ResumeLayout(false);
            this.tabQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastRichTextBoxQuery)).EndInit();
            this.tabControlResult.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainerLog.Panel1.ResumeLayout(false);
            this.splitContainerLog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLog)).EndInit();
            this.splitContainerLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastRichTextBoxLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addConectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusProgress;
        private System.Windows.Forms.SplitContainer splitContainerLog;
        private System.Windows.Forms.SplitContainer splitContainerWorkspace;
        private System.Windows.Forms.SplitContainer splitContainerQuery;
        private System.Windows.Forms.TabControl tabControlQuery;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TabControl tabControlResult;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.RichTextBox richTextBoxQueryIds;
        private System.Windows.Forms.TreeView treeViewSchemas;
        private System.Windows.Forms.Label labelSchemas;
        private System.Windows.Forms.Label labelConnection;
        private FastColoredTextBoxNS.FastColoredTextBox fastRichTextBoxQuery;
        private FastColoredTextBoxNS.FastColoredTextBox fastRichTextBoxLog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLnCol;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQueries;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQueryId;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSchemaInfo;
        private System.Windows.Forms.Panel panelSchema;
        private System.Windows.Forms.SplitContainer splitContainerSchema;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExecuteSelected;
        private System.Windows.Forms.Button buttonExecuteCurrent;
        private System.Windows.Forms.Label labelQueryId;
        private System.Windows.Forms.TextBox textBoxQueryId;
        private System.Windows.Forms.Button buttonQueryId;
        private System.Windows.Forms.Button buttonAddTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReloadConnections;
        private System.Windows.Forms.Button buttonCancelQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerStop;
    }
}

