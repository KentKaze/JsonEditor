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
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.tmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiNewJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLoadJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLoadJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiSaveJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
            this.trvJsonFiles = new System.Windows.Forms.TreeView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.imlMain = new System.Windows.Forms.ImageList(this.components);
            this.libLines = new System.Windows.Forms.ListBox();
            this.pnlFielInfo = new System.Windows.Forms.Panel();
            this.btnUpdateFileInfo = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.cobColumnType = new System.Windows.Forms.ComboBox();
            this.chbIsKey = new System.Windows.Forms.CheckBox();
            this.chbDisplay = new System.Windows.Forms.CheckBox();
            this.btnForeignKey = new System.Windows.Forms.Button();
            this.txtForeigney = new System.Windows.Forms.TextBox();
            this.tmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmiSaveJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiNewJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDeleteJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.sspMain.SuspendLayout();
            this.mspMain.SuspendLayout();
            this.pnlFielInfo.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sspMain
            // 
            this.sspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslMain});
            this.sspMain.Location = new System.Drawing.Point(0, 721);
            this.sspMain.Name = "sspMain";
            this.sspMain.Size = new System.Drawing.Size(1275, 22);
            this.sspMain.TabIndex = 0;
            this.sspMain.Text = "sspMain";
            // 
            // mspMain
            // 
            this.mspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiFile,
            this.tmiAbout});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Size = new System.Drawing.Size(1275, 28);
            this.mspMain.TabIndex = 1;
            this.mspMain.Text = "menuStrip1";
            // 
            // tmiFile
            // 
            this.tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiNewJsonFiles,
            this.tmiLoadJsonFile,
            this.tmiLoadJsonFiles,
            this.tmiSaveJsonFile,
            this.tmiSaveJsonFiles,
            this.toolStripMenuItem1,
            this.tmiExit});
            this.tmiFile.Name = "tmiFile";
            this.tmiFile.Size = new System.Drawing.Size(51, 24);
            this.tmiFile.Text = "檔案";
            // 
            // tmiNewJsonFiles
            // 
            this.tmiNewJsonFiles.Name = "tmiNewJsonFiles";
            this.tmiNewJsonFiles.Size = new System.Drawing.Size(216, 26);
            this.tmiNewJsonFiles.Text = "新建JSON資料夾";
            // 
            // tmiLoadJsonFile
            // 
            this.tmiLoadJsonFile.Name = "tmiLoadJsonFile";
            this.tmiLoadJsonFile.Size = new System.Drawing.Size(216, 26);
            this.tmiLoadJsonFile.Text = "讀取JSON檔案";
            // 
            // tmiLoadJsonFiles
            // 
            this.tmiLoadJsonFiles.Name = "tmiLoadJsonFiles";
            this.tmiLoadJsonFiles.Size = new System.Drawing.Size(216, 26);
            this.tmiLoadJsonFiles.Text = "讀取JSON資料夾";
            this.tmiLoadJsonFiles.Click += new System.EventHandler(this.tmiLoadJsonDirectory_Click);
            // 
            // tmiSaveJsonFile
            // 
            this.tmiSaveJsonFile.Name = "tmiSaveJsonFile";
            this.tmiSaveJsonFile.Size = new System.Drawing.Size(216, 26);
            this.tmiSaveJsonFile.Text = "存取JSON檔案";
            this.tmiSaveJsonFile.Click += new System.EventHandler(this.tmiSaveJson_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // tmiExit
            // 
            this.tmiExit.Name = "tmiExit";
            this.tmiExit.Size = new System.Drawing.Size(216, 26);
            this.tmiExit.Text = "離開";
            this.tmiExit.Click += new System.EventHandler(this.tmiExit_Click);
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
            this.trvJsonFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvJsonFiles_AfterSelect);
            this.trvJsonFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvJsonFiles_NodeMouseClick);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Location = new System.Drawing.Point(685, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(402, 660);
            this.pnlMain.TabIndex = 4;
            // 
            // imlMain
            // 
            this.imlMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMain.ImageStream")));
            this.imlMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imlMain.Images.SetKeyName(0, "JsonIcon.png");
            this.imlMain.Images.SetKeyName(1, "ObjectIcon.png");
            // 
            // libLines
            // 
            this.libLines.FormattingEnabled = true;
            this.libLines.ItemHeight = 16;
            this.libLines.Location = new System.Drawing.Point(296, 40);
            this.libLines.Name = "libLines";
            this.libLines.Size = new System.Drawing.Size(383, 660);
            this.libLines.TabIndex = 5;
            this.libLines.SelectedIndexChanged += new System.EventHandler(this.libLines_SelectedIndexChanged);
            // 
            // pnlFielInfo
            // 
            this.pnlFielInfo.AutoScroll = true;
            this.pnlFielInfo.Controls.Add(this.txtForeigney);
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
            this.pnlFielInfo.Size = new System.Drawing.Size(278, 183);
            this.pnlFielInfo.TabIndex = 6;
            // 
            // btnUpdateFileInfo
            // 
            this.btnUpdateFileInfo.Enabled = false;
            this.btnUpdateFileInfo.Location = new System.Drawing.Point(168, 663);
            this.btnUpdateFileInfo.Name = "btnUpdateFileInfo";
            this.btnUpdateFileInfo.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateFileInfo.TabIndex = 7;
            this.btnUpdateFileInfo.Text = "更新";
            this.btnUpdateFileInfo.UseVisualStyleBackColor = true;
            this.btnUpdateFileInfo.Click += new System.EventHandler(this.btnUpdateFileInfo_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "是索引";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "顯示在清單上";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "外部索引";
            // 
            // txtColumnName
            // 
            this.txtColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnName.Location = new System.Drawing.Point(145, 9);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(118, 27);
            this.txtColumnName.TabIndex = 0;
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
            // chbIsKey
            // 
            this.chbIsKey.AutoSize = true;
            this.chbIsKey.Location = new System.Drawing.Point(179, 84);
            this.chbIsKey.Name = "chbIsKey";
            this.chbIsKey.Size = new System.Drawing.Size(18, 17);
            this.chbIsKey.TabIndex = 8;
            this.chbIsKey.UseVisualStyleBackColor = true;
            // 
            // chbDisplay
            // 
            this.chbDisplay.AutoSize = true;
            this.chbDisplay.Location = new System.Drawing.Point(179, 119);
            this.chbDisplay.Name = "chbDisplay";
            this.chbDisplay.Size = new System.Drawing.Size(18, 17);
            this.chbDisplay.TabIndex = 13;
            this.chbDisplay.UseVisualStyleBackColor = true;
            // 
            // btnForeignKey
            // 
            this.btnForeignKey.Location = new System.Drawing.Point(244, 149);
            this.btnForeignKey.Name = "btnForeignKey";
            this.btnForeignKey.Size = new System.Drawing.Size(30, 27);
            this.btnForeignKey.TabIndex = 8;
            this.btnForeignKey.Text = "...";
            this.btnForeignKey.UseVisualStyleBackColor = true;
            // 
            // txtForeigney
            // 
            this.txtForeigney.Enabled = false;
            this.txtForeigney.Location = new System.Drawing.Point(145, 149);
            this.txtForeigney.Name = "txtForeigney";
            this.txtForeigney.Size = new System.Drawing.Size(101, 27);
            this.txtForeigney.TabIndex = 8;
            // 
            // tmiAbout
            // 
            this.tmiAbout.Name = "tmiAbout";
            this.tmiAbout.Size = new System.Drawing.Size(51, 24);
            this.tmiAbout.Text = "關於";
            this.tmiAbout.Click += new System.EventHandler(this.tmiAbout_Click);
            // 
            // sslMain
            // 
            this.sslMain.Name = "sslMain";
            this.sslMain.Size = new System.Drawing.Size(0, 17);
            // 
            // tmiSaveJsonFiles
            // 
            this.tmiSaveJsonFiles.Name = "tmiSaveJsonFiles";
            this.tmiSaveJsonFiles.Size = new System.Drawing.Size(216, 26);
            this.tmiSaveJsonFiles.Text = "存取JSON資料夾";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 743);
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
            this.pnlFielInfo.ResumeLayout(false);
            this.pnlFielInfo.PerformLayout();
            this.cmsMain.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtForeigney;
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
    }
}

