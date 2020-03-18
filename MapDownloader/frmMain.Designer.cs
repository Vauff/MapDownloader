namespace MapDownloader
{
    partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.btnMain = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.lblMapsDir = new System.Windows.Forms.Label();
			this.txtMapsDir = new System.Windows.Forms.TextBox();
			this.prgDownload = new System.Windows.Forms.ProgressBar();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.tlsAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.mnuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMain
			// 
			this.btnMain.Location = new System.Drawing.Point(203, 69);
			this.btnMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(122, 35);
			this.btnMain.TabIndex = 4;
			this.btnMain.Text = "Download Maps";
			this.btnMain.UseVisualStyleBackColor = true;
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click_Download);
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(12, 111);
			this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOutput.Size = new System.Drawing.Size(501, 220);
			this.txtOutput.TabIndex = 5;
			this.txtOutput.TabStop = false;
			// 
			// lblMapsDir
			// 
			this.lblMapsDir.AutoSize = true;
			this.lblMapsDir.Location = new System.Drawing.Point(8, 43);
			this.lblMapsDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMapsDir.Name = "lblMapsDir";
			this.lblMapsDir.Size = new System.Drawing.Size(90, 15);
			this.lblMapsDir.TabIndex = 1;
			this.lblMapsDir.Text = "Maps Directory:";
			// 
			// txtMapsDir
			// 
			this.txtMapsDir.Location = new System.Drawing.Point(110, 39);
			this.txtMapsDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMapsDir.Name = "txtMapsDir";
			this.txtMapsDir.Size = new System.Drawing.Size(338, 23);
			this.txtMapsDir.TabIndex = 2;
			// 
			// prgDownload
			// 
			this.prgDownload.Location = new System.Drawing.Point(12, 338);
			this.prgDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.prgDownload.Name = "prgDownload";
			this.prgDownload.Size = new System.Drawing.Size(502, 27);
			this.prgDownload.TabIndex = 6;
			// 
			// mnuMain
			// 
			this.mnuMain.BackColor = System.Drawing.SystemColors.ControlLight;
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAbout});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.mnuMain.Size = new System.Drawing.Size(527, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// tlsAbout
			// 
			this.tlsAbout.Name = "tlsAbout";
			this.tlsAbout.Size = new System.Drawing.Size(52, 20);
			this.tlsAbout.Text = "About";
			this.tlsAbout.Click += new System.EventHandler(this.tlsAbout_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(455, 39);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(58, 23);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// FrmMain
			// 
			this.AcceptButton = this.btnMain;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 373);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.prgDownload);
			this.Controls.Add(this.txtMapsDir);
			this.Controls.Add(this.lblMapsDir);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.mnuMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnuMain;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Map Downloader";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.mnuMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblMapsDir;
        private System.Windows.Forms.TextBox txtMapsDir;
        private System.Windows.Forms.ProgressBar prgDownload;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tlsAbout;
        private System.Windows.Forms.Button btnBrowse;
    }
}

