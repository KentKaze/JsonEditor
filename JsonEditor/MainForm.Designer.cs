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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 743);
            this.Controls.Add(this.sspMain);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sspMain;
    }
}

