namespace AthenaEditor
{
    partial class ConnectionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionManager));
            this.splitContainerConection = new System.Windows.Forms.SplitContainer();
            this.panelConections = new System.Windows.Forms.Panel();
            this.listViewConnections = new System.Windows.Forms.ListView();
            this.labelConnection = new System.Windows.Forms.Label();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.richTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.textBoxSecretKey = new System.Windows.Forms.TextBox();
            this.textBoxAccessKeyId = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxS3bucket = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelSecretId = new System.Windows.Forms.Label();
            this.labelAccessKeyId = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelS3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConection)).BeginInit();
            this.splitContainerConection.Panel1.SuspendLayout();
            this.splitContainerConection.Panel2.SuspendLayout();
            this.splitContainerConection.SuspendLayout();
            this.panelConections.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerConection
            // 
            this.splitContainerConection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerConection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerConection.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerConection.Location = new System.Drawing.Point(12, 12);
            this.splitContainerConection.Name = "splitContainerConection";
            // 
            // splitContainerConection.Panel1
            // 
            this.splitContainerConection.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainerConection.Panel1.Controls.Add(this.panelConections);
            // 
            // splitContainerConection.Panel2
            // 
            this.splitContainerConection.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainerConection.Panel2.Controls.Add(this.panelConfig);
            this.splitContainerConection.Size = new System.Drawing.Size(776, 362);
            this.splitContainerConection.SplitterDistance = 207;
            this.splitContainerConection.TabIndex = 0;
            // 
            // panelConections
            // 
            this.panelConections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConections.Controls.Add(this.listViewConnections);
            this.panelConections.Controls.Add(this.labelConnection);
            this.panelConections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConections.Location = new System.Drawing.Point(0, 0);
            this.panelConections.Name = "panelConections";
            this.panelConections.Size = new System.Drawing.Size(207, 362);
            this.panelConections.TabIndex = 0;
            // 
            // listViewConnections
            // 
            this.listViewConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewConnections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewConnections.FullRowSelect = true;
            this.listViewConnections.HideSelection = false;
            this.listViewConnections.Location = new System.Drawing.Point(20, 24);
            this.listViewConnections.MultiSelect = false;
            this.listViewConnections.Name = "listViewConnections";
            this.listViewConnections.Size = new System.Drawing.Size(182, 332);
            this.listViewConnections.TabIndex = 1;
            this.listViewConnections.UseCompatibleStateImageBehavior = false;
            this.listViewConnections.View = System.Windows.Forms.View.Details;
            this.listViewConnections.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewConnections_ItemSelectionChanged);
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.Location = new System.Drawing.Point(4, 4);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(122, 16);
            this.labelConnection.TabIndex = 0;
            this.labelConnection.Text = "Connection Names";
            // 
            // panelConfig
            // 
            this.panelConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfig.Controls.Add(this.comboBoxRegion);
            this.panelConfig.Controls.Add(this.richTextBoxComments);
            this.panelConfig.Controls.Add(this.textBoxSecretKey);
            this.panelConfig.Controls.Add(this.textBoxAccessKeyId);
            this.panelConfig.Controls.Add(this.textBoxDatabase);
            this.panelConfig.Controls.Add(this.textBoxS3bucket);
            this.panelConfig.Controls.Add(this.textBoxName);
            this.panelConfig.Controls.Add(this.labelName);
            this.panelConfig.Controls.Add(this.labelComments);
            this.panelConfig.Controls.Add(this.labelRegion);
            this.panelConfig.Controls.Add(this.labelSecretId);
            this.panelConfig.Controls.Add(this.labelAccessKeyId);
            this.panelConfig.Controls.Add(this.labelDatabase);
            this.panelConfig.Controls.Add(this.labelS3);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfig.Location = new System.Drawing.Point(0, 0);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(565, 362);
            this.panelConfig.TabIndex = 0;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Items.AddRange(new object[] {
            "AP_SOUTH_1",
            "EU_NORTH_1",
            "EU_WEST_3",
            "EU_WEST_2",
            "EU_WEST_1",
            "AP_NORTHEAST_2",
            "AP_NORTHEAST_1",
            "US_GOV_EAST_1",
            "CA_CENTRAL_1",
            "SA_EAST_1",
            "CN_NORTH_1",
            "US_GOV_WEST_1",
            "AP_SOUTHEAST_1",
            "AP_SOUTHEAST_2",
            "EU_CENTRAL_1",
            "US_EAST_1",
            "US_EAST_2",
            "US_WEST_1",
            "CN_NORTHWEST_1",
            "US_WEST_2",
            "AWS_GLOBAL",
            "AWS_CN_GLOBAL",
            "AWS_US_GOV_GLOBAL"});
            this.comboBoxRegion.Location = new System.Drawing.Point(165, 145);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(384, 21);
            this.comboBoxRegion.TabIndex = 6;
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxComments.Location = new System.Drawing.Point(165, 172);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(384, 171);
            this.richTextBoxComments.TabIndex = 7;
            this.richTextBoxComments.Text = "";
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Location = new System.Drawing.Point(165, 116);
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(384, 20);
            this.textBoxSecretKey.TabIndex = 5;
            // 
            // textBoxAccessKeyId
            // 
            this.textBoxAccessKeyId.Location = new System.Drawing.Point(165, 88);
            this.textBoxAccessKeyId.Name = "textBoxAccessKeyId";
            this.textBoxAccessKeyId.Size = new System.Drawing.Size(384, 20);
            this.textBoxAccessKeyId.TabIndex = 4;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(165, 60);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(384, 20);
            this.textBoxDatabase.TabIndex = 3;
            // 
            // textBoxS3bucket
            // 
            this.textBoxS3bucket.Location = new System.Drawing.Point(165, 32);
            this.textBoxS3bucket.Name = "textBoxS3bucket";
            this.textBoxS3bucket.Size = new System.Drawing.Size(384, 20);
            this.textBoxS3bucket.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(384, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "ConnectionName:";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(12, 172);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(75, 16);
            this.labelComments.TabIndex = 6;
            this.labelComments.Text = "Comments:";
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion.Location = new System.Drawing.Point(12, 145);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(55, 16);
            this.labelRegion.TabIndex = 5;
            this.labelRegion.Text = "Region:";
            // 
            // labelSecretId
            // 
            this.labelSecretId.AutoSize = true;
            this.labelSecretId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecretId.Location = new System.Drawing.Point(12, 116);
            this.labelSecretId.Name = "labelSecretId";
            this.labelSecretId.Size = new System.Drawing.Size(132, 16);
            this.labelSecretId.TabIndex = 4;
            this.labelSecretId.Text = "Secrete Access Key:";
            // 
            // labelAccessKeyId
            // 
            this.labelAccessKeyId.AutoSize = true;
            this.labelAccessKeyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessKeyId.Location = new System.Drawing.Point(12, 88);
            this.labelAccessKeyId.Name = "labelAccessKeyId";
            this.labelAccessKeyId.Size = new System.Drawing.Size(96, 16);
            this.labelAccessKeyId.TabIndex = 3;
            this.labelAccessKeyId.Text = "Access Key Id:";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabase.Location = new System.Drawing.Point(12, 60);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(74, 16);
            this.labelDatabase.TabIndex = 2;
            this.labelDatabase.Text = "Database: ";
            // 
            // labelS3
            // 
            this.labelS3.AutoSize = true;
            this.labelS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS3.Location = new System.Drawing.Point(12, 32);
            this.labelS3.Name = "labelS3";
            this.labelS3.Size = new System.Drawing.Size(109, 16);
            this.labelS3.TabIndex = 1;
            this.labelS3.Text = "S3 output bucket:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.buttonTest);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(551, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 28);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(713, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 28);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.buttonTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.ForeColor = System.Drawing.Color.White;
            this.buttonTest.Location = new System.Drawing.Point(632, 5);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 28);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(114, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 28);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.buttonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Location = new System.Drawing.Point(33, 5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 28);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // ConnectionManager
            // 
            this.AcceptButton = this.buttonOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainerConection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Manager";
            this.splitContainerConection.Panel1.ResumeLayout(false);
            this.splitContainerConection.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConection)).EndInit();
            this.splitContainerConection.ResumeLayout(false);
            this.panelConections.ResumeLayout(false);
            this.panelConections.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerConection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Panel panelConections;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label labelS3;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelSecretId;
        private System.Windows.Forms.Label labelAccessKeyId;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
        private System.Windows.Forms.TextBox textBoxSecretKey;
        private System.Windows.Forms.TextBox textBoxAccessKeyId;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxS3bucket;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListView listViewConnections;
    }
}