namespace MapDownloader
{
    partial class FrmStartup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartup));
			this.txtFastdlUrl = new System.Windows.Forms.TextBox();
			this.lblFastdlUrl = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtMaplistUrl = new System.Windows.Forms.TextBox();
			this.lblMaplistUrl = new System.Windows.Forms.Label();
			this.lbServers = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// txtFastdlUrl
			// 
			this.txtFastdlUrl.Location = new System.Drawing.Point(108, 212);
			this.txtFastdlUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtFastdlUrl.Name = "txtFastdlUrl";
			this.txtFastdlUrl.Size = new System.Drawing.Size(268, 23);
			this.txtFastdlUrl.TabIndex = 1;
			// 
			// lblFastdlUrl
			// 
			this.lblFastdlUrl.AutoSize = true;
			this.lblFastdlUrl.Location = new System.Drawing.Point(14, 215);
			this.lblFastdlUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFastdlUrl.Name = "lblFastdlUrl";
			this.lblFastdlUrl.Size = new System.Drawing.Size(69, 15);
			this.lblFastdlUrl.TabIndex = 0;
			this.lblFastdlUrl.Text = "FastDL URL:";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(134, 275);
			this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(122, 35);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtMaplistUrl
			// 
			this.txtMaplistUrl.Location = new System.Drawing.Point(108, 242);
			this.txtMaplistUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMaplistUrl.Name = "txtMaplistUrl";
			this.txtMaplistUrl.Size = new System.Drawing.Size(268, 23);
			this.txtMaplistUrl.TabIndex = 3;
			// 
			// lblMaplistUrl
			// 
			this.lblMaplistUrl.AutoSize = true;
			this.lblMaplistUrl.Location = new System.Drawing.Point(14, 245);
			this.lblMaplistUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMaplistUrl.Name = "lblMaplistUrl";
			this.lblMaplistUrl.Size = new System.Drawing.Size(79, 15);
			this.lblMaplistUrl.TabIndex = 2;
			this.lblMaplistUrl.Text = "Map List URL:";
			// 
			// lbServers
			// 
			this.lbServers.FormattingEnabled = true;
			this.lbServers.ItemHeight = 15;
			this.lbServers.Location = new System.Drawing.Point(14, 13);
			this.lbServers.Name = "lbServers";
			this.lbServers.Size = new System.Drawing.Size(362, 184);
			this.lbServers.TabIndex = 5;
			this.lbServers.SelectedIndexChanged += new System.EventHandler(this.lbServers_SelectedIndexChanged);
			// 
			// FrmStartup
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 321);
			this.Controls.Add(this.lbServers);
			this.Controls.Add(this.txtMaplistUrl);
			this.Controls.Add(this.lblMaplistUrl);
			this.Controls.Add(this.txtFastdlUrl);
			this.Controls.Add(this.lblFastdlUrl);
			this.Controls.Add(this.btnStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "FrmStartup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Map Downloader: Select Server";
			this.Load += new System.EventHandler(this.frmStartup_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFastdlUrl;
        private System.Windows.Forms.Label lblFastdlUrl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtMaplistUrl;
        private System.Windows.Forms.Label lblMaplistUrl;
		private System.Windows.Forms.ListBox lbServers;
	}
}