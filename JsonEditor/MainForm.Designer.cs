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
            this.sspMain = new System.Windows.Forms.StatusStrip();
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.tmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiNewJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLoadJsonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLoadJsonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiSaveJson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
            this.mspMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sspMain
            // 
            this.sspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.tmiFile});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Size = new System.Drawing.Size(1275, 28);
            this.mspMain.TabIndex = 1;
            this.mspMain.Text = "menuStrip1";
            // 
            // tmiFile
            // 
            this.tmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiNewJsonFile,
            this.tmiLoadJsonFile,
            this.tmiLoadJsonFiles,
            this.tmiSaveJson,
            this.toolStripMenuItem1,
            this.tmiExit});
            this.tmiFile.Name = "tmiFile";
            this.tmiFile.Size = new System.Drawing.Size(51, 24);
            this.tmiFile.Text = "檔案";
            // 
            // tmiNewJsonFile
            // 
            this.tmiNewJsonFile.Name = "tmiNewJsonFile";
            this.tmiNewJsonFile.Size = new System.Drawing.Size(216, 26);
            this.tmiNewJsonFile.Text = "新Json";
            // 
            // tmiLoadJsonFile
            // 
            this.tmiLoadJsonFile.Name = "tmiLoadJsonFile";
            this.tmiLoadJsonFile.Size = new System.Drawing.Size(216, 26);
            this.tmiLoadJsonFile.Text = "讀取Json";
            // 
            // tmiLoadJsonFiles
            // 
            this.tmiLoadJsonFiles.Name = "tmiLoadJsonFiles";
            this.tmiLoadJsonFiles.Size = new System.Drawing.Size(216, 26);
            this.tmiLoadJsonFiles.Text = "讀取Json資料夾";
            this.tmiLoadJsonFiles.Click += new System.EventHandler(this.tmiLoadJsonDirectory_Click);
            // 
            // tmiSaveJson
            // 
            this.tmiSaveJson.Name = "tmiSaveJson";
            this.tmiSaveJson.Size = new System.Drawing.Size(216, 26);
            this.tmiSaveJson.Text = "存檔";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 743);
            this.Controls.Add(this.sspMain);
            this.Controls.Add(this.mspMain);
            this.MainMenuStrip = this.mspMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mspMain.ResumeLayout(false);
            this.mspMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sspMain;
        private System.Windows.Forms.MenuStrip mspMain;
        private System.Windows.Forms.ToolStripMenuItem tmiFile;
        private System.Windows.Forms.ToolStripMenuItem tmiNewJsonFile;
        private System.Windows.Forms.ToolStripMenuItem tmiLoadJsonFile;
        private System.Windows.Forms.ToolStripMenuItem tmiLoadJsonFiles;
        private System.Windows.Forms.ToolStripMenuItem tmiSaveJson;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tmiExit;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.FolderBrowserDialog fbdMain;
    }
}

