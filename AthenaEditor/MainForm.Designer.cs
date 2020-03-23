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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQueryId = new System.Windows.Forms.Button();
            this.textBoxQueryId = new System.Windows.Forms.TextBox();
            this.labelQueryId = new System.Windows.Forms.Label();
            this.buttonExecuteCurrent = new System.Windows.Forms.Button();
            this.buttonExecuteSelected = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerWorkspace = new System.Windows.Forms.SplitContainer();
            this.splitContainerQuery = new System.Windows.Forms.SplitContainer();
            this.tabControlQuery = new System.Windows.Forms.TabControl();
            this.tabQuey = new System.Windows.Forms.TabPage();
            this.richTextBoxQuery = new System.Windows.Forms.RichTextBox();
            this.tabQueryAdd = new System.Windows.Forms.TabPage();
            this.richTextBoxQueryIds = new System.Windows.Forms.RichTextBox();
            this.tabControlResult = new System.Windows.Forms.TabControl();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerLog = new System.Windows.Forms.SplitContainer();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.treeViewSchemas = new System.Windows.Forms.TreeView();
            this.menuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkspace)).BeginInit();
            this.splitContainerWorkspace.Panel1.SuspendLayout();
            this.splitContainerWorkspace.Panel2.SuspendLayout();
            this.splitContainerWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuery)).BeginInit();
            this.splitContainerQuery.Panel1.SuspendLayout();
            this.splitContainerQuery.Panel2.SuspendLayout();
            this.splitContainerQuery.SuspendLayout();
            this.tabControlQuery.SuspendLayout();
            this.tabQuey.SuspendLayout();
            this.tabControlResult.SuspendLayout();
            this.tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLog)).BeginInit();
            this.splitContainerLog.Panel1.SuspendLayout();
            this.splitContainerLog.Panel2.SuspendLayout();
            this.splitContainerLog.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // buttonQueryId
            // 
            this.buttonQueryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQueryId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonQueryId.FlatAppearance.BorderSize = 0;
            this.buttonQueryId.Image = ((System.Drawing.Image)(resources.GetObject("buttonQueryId.Image")));
            this.buttonQueryId.Location = new System.Drawing.Point(1000, -1);
            this.buttonQueryId.Name = "buttonQueryId";
            this.buttonQueryId.Size = new System.Drawing.Size(20, 22);
            this.buttonQueryId.TabIndex = 6;
            this.buttonQueryId.UseVisualStyleBackColor = false;
            this.buttonQueryId.Click += new System.EventHandler(this.buttonQueryId_Click);
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
            // buttonExecuteCurrent
            // 
            this.buttonExecuteCurrent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExecuteCurrent.FlatAppearance.BorderSize = 0;
            this.buttonExecuteCurrent.Image = ((System.Drawing.Image)(resources.GetObject("buttonExecuteCurrent.Image")));
            this.buttonExecuteCurrent.Location = new System.Drawing.Point(320, -1);
            this.buttonExecuteCurrent.Name = "buttonExecuteCurrent";
            this.buttonExecuteCurrent.Size = new System.Drawing.Size(20, 22);
            this.buttonExecuteCurrent.TabIndex = 3;
            this.buttonExecuteCurrent.UseVisualStyleBackColor = false;
            this.buttonExecuteCurrent.Click += new System.EventHandler(this.buttonExecuteCurrent_Click);
            // 
            // buttonExecuteSelected
            // 
            this.buttonExecuteSelected.Image = ((System.Drawing.Image)(resources.GetObject("buttonExecuteSelected.Image")));
            this.buttonExecuteSelected.Location = new System.Drawing.Point(298, -1);
            this.buttonExecuteSelected.Name = "buttonExecuteSelected";
            this.buttonExecuteSelected.Size = new System.Drawing.Size(21, 22);
            this.buttonExecuteSelected.TabIndex = 2;
            this.buttonExecuteSelected.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(266, -1);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(21, 22);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
            this.buttonLoad.Location = new System.Drawing.Point(244, -1);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(21, 22);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.UseVisualStyleBackColor = true;
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
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewSchemas);
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
            this.tabControlQuery.Controls.Add(this.tabQuey);
            this.tabControlQuery.Controls.Add(this.tabQueryAdd);
            this.tabControlQuery.Location = new System.Drawing.Point(0, 3);
            this.tabControlQuery.Name = "tabControlQuery";
            this.tabControlQuery.SelectedIndex = 0;
            this.tabControlQuery.Size = new System.Drawing.Size(592, 202);
            this.tabControlQuery.TabIndex = 0;
            // 
            // tabQuey
            // 
            this.tabQuey.Controls.Add(this.richTextBoxQuery);
            this.tabQuey.Location = new System.Drawing.Point(4, 22);
            this.tabQuey.Name = "tabQuey";
            this.tabQuey.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuey.Size = new System.Drawing.Size(584, 176);
            this.tabQuey.TabIndex = 0;
            this.tabQuey.Text = "query";
            this.tabQuey.UseVisualStyleBackColor = true;
            // 
            // richTextBoxQuery
            // 
            this.richTextBoxQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxQuery.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQuery.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxQuery.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxQuery.Name = "richTextBoxQuery";
            this.richTextBoxQuery.Size = new System.Drawing.Size(578, 170);
            this.richTextBoxQuery.TabIndex = 0;
            this.richTextBoxQuery.Text = "";
            this.richTextBoxQuery.WordWrap = false;
            this.richTextBoxQuery.TextChanged += new System.EventHandler(this.richTextBoxQuery_TextChanged);
            this.richTextBoxQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxQuery_KeyDown);
            // 
            // tabQueryAdd
            // 
            this.tabQueryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQueryAdd.Location = new System.Drawing.Point(4, 22);
            this.tabQueryAdd.Name = "tabQueryAdd";
            this.tabQueryAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueryAdd.Size = new System.Drawing.Size(584, 176);
            this.tabQueryAdd.TabIndex = 1;
            this.tabQueryAdd.Text = "+";
            this.tabQueryAdd.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResult.Size = new System.Drawing.Size(769, 134);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusProgress});
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
            this.splitContainerLog.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainerLog.Size = new System.Drawing.Size(1028, 454);
            this.splitContainerLog.SplitterDistance = 383;
            this.splitContainerLog.TabIndex = 4;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(1028, 67);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // treeViewSchemas
            // 
            this.treeViewSchemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSchemas.Location = new System.Drawing.Point(4, 4);
            this.treeViewSchemas.Name = "treeViewSchemas";
            this.treeViewSchemas.Size = new System.Drawing.Size(234, 370);
            this.treeViewSchemas.TabIndex = 0;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerWorkspace.Panel1.ResumeLayout(false);
            this.splitContainerWorkspace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWorkspace)).EndInit();
            this.splitContainerWorkspace.ResumeLayout(false);
            this.splitContainerQuery.Panel1.ResumeLayout(false);
            this.splitContainerQuery.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuery)).EndInit();
            this.splitContainerQuery.ResumeLayout(false);
            this.tabControlQuery.ResumeLayout(false);
            this.tabQuey.ResumeLayout(false);
            this.tabControlResult.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainerLog.Panel1.ResumeLayout(false);
            this.splitContainerLog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLog)).EndInit();
            this.splitContainerLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addConectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusProgress;
        private System.Windows.Forms.SplitContainer splitContainerLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.SplitContainer splitContainerWorkspace;
        private System.Windows.Forms.SplitContainer splitContainerQuery;
        private System.Windows.Forms.TabControl tabControlQuery;
        private System.Windows.Forms.TabPage tabQuey;
        private System.Windows.Forms.TabPage tabQueryAdd;
        private System.Windows.Forms.TabControl tabControlResult;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.RichTextBox richTextBoxQuery;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonExecuteSelected;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExecuteCurrent;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonQueryId;
        private System.Windows.Forms.TextBox textBoxQueryId;
        private System.Windows.Forms.Label labelQueryId;
        private System.Windows.Forms.RichTextBox richTextBoxQueryIds;
        private System.Windows.Forms.TreeView treeViewSchemas;
    }
}

