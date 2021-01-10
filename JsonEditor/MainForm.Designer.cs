namespace JsonEditor
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
            this.sspMain = new System.Windows.Forms.StatusStrip();
            this.sslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.tmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiNewJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiLoadJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLoadJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiSaveJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiSaveJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiCloseAllJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
            this.trvJsonFiles = new System.Windows.Forms.TreeView();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiNewJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDeleteJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.imlMain = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.libLines = new System.Windows.Forms.ListBox();
            this.pnlFielInfo = new System.Windows.Forms.Panel();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtForeignKey = new System.Windows.Forms.TextBox();
            this.btnForeignKey = new System.Windows.Forms.Button();
            this.chbDisplay = new System.Windows.Forms.CheckBox();
            this.chbIsKey = new System.Windows.Forms.CheckBox();
            this.cobColumnType = new System.Windows.Forms.ComboBox();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnUpdateFileInfo = new System.Windows.Forms.Button();
            this.btnUpdateMain = new System.Windows.Forms.Button();
            this.btnClearMain = new System.Windows.Forms.Button();
            this.sspMain.SuspendLayout();
            this.mspMain.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.pnlFielInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // sspMain
            // 
            this.sspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslMain});
            this.sspMain.Location = new System.Drawing.Point(0, 755);
            this.sspMain.Name = "sspMain";
            this.sspMain.Size = new System.Drawing.Size(1272, 22);
            this.sspMain.TabIndex = 0;
            this.sspMain.Text = "sspMain";
            // 
            // sslMain
            // 
            this.sslMain.Name = "sslMain";
            this.sslMain.Size = new System.Drawing.Size(0, 17);
            // 
            // mspMain
            // 
            this.mspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiFile,
            this.tmiAbout});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Size = new System.Drawing.Size(1272, 28);
            this.mspMain.TabIndex = 1;
            this.mspMain.Text = "menuStrip1";
            // 
            // tmiFile
            // 
            this.tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiNewJsonFiles,
            this.toolStripMenuItem3,
            this.tmiLoadJsonFile,
            this.tmiLoadJsonFiles,
            this.toolStripMenuItem4,
            this.tmiSaveJsonFile,
            this.tmiSaveJsonFiles,
            this.toolStripMenuItem2,
            this.tmiCloseAllJsonFiles,
            this.toolStripMenuItem1,
            this.tmiExit});
            this.tmiFile.Name = "tmiFile";
            this.tmiFile.Size = new System.Drawing.Size(51, 24);
            this.tmiFile.Text = "檔案";
            // 
            // tmiNewJsonFiles
            // 
            this.tmiNewJsonFiles.Name = "tmiNewJsonFiles";
            this.tmiNewJsonFiles.Size = new System.Drawing.Size(194, 26);
            this.tmiNewJsonFiles.Text = "新建JSON資料夾";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 6);
            // 
            // tmiLoadJsonFile
            // 
            this.tmiLoadJsonFile.Name = "tmiLoadJsonFile";
            this.tmiLoadJsonFile.Size = new System.Drawing.Size(194, 26);
            this.tmiLoadJsonFile.Text = "讀取JSON檔案";
            this.tmiLoadJsonFile.Click += new System.EventHandler(this.tmiLoadJsonFile_Click);
            // 
            // tmiLoadJsonFiles
            // 
            this.tmiLoadJsonFiles.Name = "tmiLoadJsonFiles";
            this.tmiLoadJsonFiles.Size = new System.Drawing.Size(194, 26);
            this.tmiLoadJsonFiles.Text = "讀取JSON資料夾";
            this.tmiLoadJsonFiles.Click += new System.EventHandler(this.tmiLoadJsonDirectory_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(191, 6);
            // 
            // tmiSaveJsonFile
            // 
            this.tmiSaveJsonFile.Name = "tmiSaveJsonFile";
            this.tmiSaveJsonFile.Size = new System.Drawing.Size(194, 26);
            this.tmiSaveJsonFile.Text = "存取JSON檔案";
            this.tmiSaveJsonFile.Click += new System.EventHandler(this.tmiSaveJsonFile_Click);
            // 
            // tmiSaveJsonFiles
            // 
            this.tmiSaveJsonFiles.Name = "tmiSaveJsonFiles";
            this.tmiSaveJsonFiles.Size = new System.Drawing.Size(194, 26);
            this.tmiSaveJsonFiles.Text = "存取JSON資料夾";
            this.tmiSaveJsonFiles.Click += new System.EventHandler(this.tmiSaveJsonFiles_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // tmiCloseAllJsonFiles
            // 
            this.tmiCloseAllJsonFiles.Enabled = false;
            this.tmiCloseAllJsonFiles.Name = "tmiCloseAllJsonFiles";
            this.tmiCloseAllJsonFiles.Size = new System.Drawing.Size(194, 26);
            this.tmiCloseAllJsonFiles.Text = "關閉所有檔案";
            this.tmiCloseAllJsonFiles.Click += new System.EventHandler(this.tmiCloseAllJsonFiles_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // tmiExit
            // 
            this.tmiExit.Name = "tmiExit";
            this.tmiExit.Size = new System.Drawing.Size(194, 26);
            this.tmiExit.Text = "離開";
            this.tmiExit.Click += new System.EventHandler(this.tmiExit_Click);
            // 
            // tmiAbout
            // 
            this.tmiAbout.Name = "tmiAbout";
            this.tmiAbout.Size = new System.Drawing.Size(51, 24);
            this.tmiAbout.Text = "關於";
            this.tmiAbout.Click += new System.EventHandler(this.tmiAbout_Click);
            // 
            // ofdMain
            // 
            this.ofdMain.FileName = "openFileDialog1";
            // 
            // trvJsonFiles
            // 
            this.trvJsonFiles.ContextMenuStrip = this.cmsMain;
            this.trvJsonFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvJsonFiles.ImageIndex = 0;
            this.trvJsonFiles.ImageList = this.imlMain;
            this.trvJsonFiles.Location = new System.Drawing.Point(12, 40);
            this.trvJsonFiles.Name = "trvJsonFiles";
            this.trvJsonFiles.SelectedImageIndex = 0;
            this.trvJsonFiles.Size = new System.Drawing.Size(278, 428);
            this.trvJsonFiles.TabIndex = 3;
            this.trvJsonFiles.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvJsonFiles_BeforeCollapse);
            this.trvJsonFiles.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvJsonFiles_BeforeExpand);
            this.trvJsonFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvJsonFiles_AfterSelect);
            this.trvJsonFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvJsonFiles_NodeMouseClick);
            this.trvJsonFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvJsonFiles_NodeMouseDoubleClick);
            this.trvJsonFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvJsonFiles_MouseDown);
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiNewJsonFile,
            this.tmiDeleteJsonFile});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(174, 52);
            // 
            // tmiNewJsonFile
            // 
            this.tmiNewJsonFile.Name = "tmiNewJsonFile";
            this.tmiNewJsonFile.Size = new System.Drawing.Size(173, 24);
            this.tmiNewJsonFile.Text = "新增JSON檔案";
            this.tmiNewJsonFile.Click += new System.EventHandler(this.tmiNewJsonFile_Click);
            // 
            // tmiDeleteJsonFile
            // 
            this.tmiDeleteJsonFile.Name = "tmiDeleteJsonFile";
            this.tmiDeleteJsonFile.Size = new System.Drawing.Size(173, 24);
            this.tmiDeleteJsonFile.Text = "刪除JSON檔案";
            // 
            // imlMain
            // 
            this.imlMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMain.ImageStream")));
            this.imlMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imlMain.Images.SetKeyName(0, "JsonIcon.png");
            this.imlMain.Images.SetKeyName(1, "ObjectIcon.png");
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Location = new System.Drawing.Point(685, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(575, 657);
            this.pnlMain.TabIndex = 4;
            // 
            // libLines
            // 
            this.libLines.FormattingEnabled = true;
            this.libLines.ItemHeight = 16;
            this.libLines.Location = new System.Drawing.Point(296, 40);
            this.libLines.Name = "libLines";
            this.libLines.Size = new System.Drawing.Size(383, 708);
            this.libLines.TabIndex = 5;
            this.libLines.SelectedIndexChanged += new System.EventHandler(this.libLines_SelectedIndexChanged);
            // 
            // pnlFielInfo
            // 
            this.pnlFielInfo.AutoScroll = true;
            this.pnlFielInfo.Controls.Add(this.txtNumberOfRows);
            this.pnlFielInfo.Controls.Add(this.label5);
            this.pnlFielInfo.Controls.Add(this.txtForeignKey);
            this.pnlFielInfo.Controls.Add(this.btnForeignKey);
            this.pnlFielInfo.Controls.Add(this.chbDisplay);
            this.pnlFielInfo.Controls.Add(this.chbIsKey);
            this.pnlFielInfo.Controls.Add(this.cobColumnType);
            this.pnlFielInfo.Controls.Add(this.txtColumnName);
            this.pnlFielInfo.Controls.Add(this.label4);
            this.pnlFielInfo.Controls.Add(this.label3);
            this.pnlFielInfo.Controls.Add(this.label2);
            this.pnlFielInfo.Controls.Add(this.label1);
            this.pnlFielInfo.Controls.Add(this.lbl1);
            this.pnlFielInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFielInfo.Location = new System.Drawing.Point(12, 474);
            this.pnlFielInfo.Name = "pnlFielInfo";
            this.pnlFielInfo.Size = new System.Drawing.Size(278, 223);
            this.pnlFielInfo.TabIndex = 6;
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfRows.Location = new System.Drawing.Point(227, 79);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(36, 27);
            this.txtNumberOfRows.TabIndex = 15;
            this.txtNumberOfRows.Text = "0";
            this.txtNumberOfRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "欄位行數";
            // 
            // txtForeignKey
            // 
            this.txtForeignKey.Enabled = false;
            this.txtForeignKey.Location = new System.Drawing.Point(145, 184);
            this.txtForeignKey.Name = "txtForeignKey";
            this.txtForeignKey.Size = new System.Drawing.Size(101, 27);
            this.txtForeignKey.TabIndex = 8;
            // 
            // btnForeignKey
            // 
            this.btnForeignKey.Location = new System.Drawing.Point(245, 184);
            this.btnForeignKey.Name = "btnForeignKey";
            this.btnForeignKey.Size = new System.Drawing.Size(30, 27);
            this.btnForeignKey.TabIndex = 8;
            this.btnForeignKey.Text = "...";
            this.btnForeignKey.UseVisualStyleBackColor = true;
            // 
            // chbDisplay
            // 
            this.chbDisplay.AutoSize = true;
            this.chbDisplay.Location = new System.Drawing.Point(179, 154);
            this.chbDisplay.Name = "chbDisplay";
            this.chbDisplay.Size = new System.Drawing.Size(18, 17);
            this.chbDisplay.TabIndex = 13;
            this.chbDisplay.UseVisualStyleBackColor = true;
            // 
            // chbIsKey
            // 
            this.chbIsKey.AutoSize = true;
            this.chbIsKey.Location = new System.Drawing.Point(179, 119);
            this.chbIsKey.Name = "chbIsKey";
            this.chbIsKey.Size = new System.Drawing.Size(18, 17);
            this.chbIsKey.TabIndex = 8;
            this.chbIsKey.UseVisualStyleBackColor = true;
            // 
            // cobColumnType
            // 
            this.cobColumnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobColumnType.FormattingEnabled = true;
            this.cobColumnType.Location = new System.Drawing.Point(145, 44);
            this.cobColumnType.Name = "cobColumnType";
            this.cobColumnType.Size = new System.Drawing.Size(118, 28);
            this.cobColumnType.TabIndex = 8;
            // 
            // txtColumnName
            // 
            this.txtColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnName.Location = new System.Drawing.Point(145, 9);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(118, 27);
            this.txtColumnName.TabIndex = 0;
            this.txtColumnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "外部索引";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "顯示在清單上";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "是索引";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "欄位型別";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(18, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(77, 20);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "欄位名稱";
            // 
            // btnUpdateFileInfo
            // 
            this.btnUpdateFileInfo.Enabled = false;
            this.btnUpdateFileInfo.Location = new System.Drawing.Point(168, 703);
            this.btnUpdateFileInfo.Name = "btnUpdateFileInfo";
            this.btnUpdateFileInfo.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateFileInfo.TabIndex = 7;
            this.btnUpdateFileInfo.Text = "更新";
            this.btnUpdateFileInfo.UseVisualStyleBackColor = true;
            this.btnUpdateFileInfo.Click += new System.EventHandler(this.btnUpdateFileInfo_Click);
            // 
            // btnUpdateMain
            // 
            this.btnUpdateMain.Enabled = false;
            this.btnUpdateMain.Location = new System.Drawing.Point(1138, 703);
            this.btnUpdateMain.Name = "btnUpdateMain";
            this.btnUpdateMain.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateMain.TabIndex = 8;
            this.btnUpdateMain.Text = "更新";
            this.btnUpdateMain.UseVisualStyleBackColor = true;
            this.btnUpdateMain.Click += new System.EventHandler(this.btnUpdateMain_Click);
            // 
            // btnClearMain
            // 
            this.btnClearMain.Enabled = false;
            this.btnClearMain.Location = new System.Drawing.Point(685, 703);
            this.btnClearMain.Name = "btnClearMain";
            this.btnClearMain.Size = new System.Drawing.Size(122, 40);
            this.btnClearMain.TabIndex = 9;
            this.btnClearMain.Text = "清空";
            this.btnClearMain.UseVisualStyleBackColor = true;
            this.btnClearMain.Click += new System.EventHandler(this.btnClearMain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 777);
            this.Controls.Add(this.btnClearMain);
            this.Controls.Add(this.btnUpdateMain);
            this.Controls.Add(this.btnUpdateFileInfo);
            this.Controls.Add(this.pnlFielInfo);
            this.Controls.Add(this.libLines);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.trvJsonFiles);
            this.Controls.Add(this.sspMain);
            this.Controls.Add(this.mspMain);
            this.MainMenuStrip = this.mspMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "JSON 資料檔案編輯器";
            this.sspMain.ResumeLayout(false);
            this.sspMain.PerformLayout();
            this.mspMain.ResumeLayout(false);
            this.mspMain.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.pnlFielInfo.ResumeLayout(false);
            this.pnlFielInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sspMain;
        private System.Windows.Forms.MenuStrip mspMain;
        private System.Windows.Forms.ToolStripMenuItem tmiFile;
        private System.Windows.Forms.ToolStripMenuItem tmiNewJsonFiles;
        private System.Windows.Forms.ToolStripMenuItem tmiLoadJsonFile;
        private System.Windows.Forms.ToolStripMenuItem tmiLoadJsonFiles;
        private System.Windows.Forms.ToolStripMenuItem tmiSaveJsonFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tmiExit;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.FolderBrowserDialog fbdMain;
        private System.Windows.Forms.TreeView trvJsonFiles;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ImageList imlMain;
        private System.Windows.Forms.ListBox libLines;
        private System.Windows.Forms.Panel pnlFielInfo;
        private System.Windows.Forms.Button btnUpdateFileInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtForeignKey;
        private System.Windows.Forms.Button btnForeignKey;
        private System.Windows.Forms.CheckBox chbDisplay;
        private System.Windows.Forms.CheckBox chbIsKey;
        private System.Windows.Forms.ComboBox cobColumnType;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tmiAbout;
        private System.Windows.Forms.ToolStripStatusLabel sslMain;
        private System.Windows.Forms.ToolStripMenuItem tmiSaveJsonFiles;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tmiNewJsonFile;
        private System.Windows.Forms.ToolStripMenuItem tmiDeleteJsonFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tmiCloseAllJsonFiles;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateMain;
        private System.Windows.Forms.Button btnClearMain;
    }
}

