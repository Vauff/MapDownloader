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
			txtFastdlUrl = new System.Windows.Forms.TextBox();
			lblFastdlUrl = new System.Windows.Forms.Label();
			btnStart = new System.Windows.Forms.Button();
			txtMaplistUrl = new System.Windows.Forms.TextBox();
			lblMaplistUrl = new System.Windows.Forms.Label();
			lbServers = new System.Windows.Forms.ListBox();
			SuspendLayout();
			// 
			// txtFastdlUrl
			// 
			txtFastdlUrl.Location = new System.Drawing.Point(108, 212);
			txtFastdlUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtFastdlUrl.Name = "txtFastdlUrl";
			txtFastdlUrl.Size = new System.Drawing.Size(268, 23);
			txtFastdlUrl.TabIndex = 1;
			// 
			// lblFastdlUrl
			// 
			lblFastdlUrl.AutoSize = true;
			lblFastdlUrl.Location = new System.Drawing.Point(14, 215);
			lblFastdlUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblFastdlUrl.Name = "lblFastdlUrl";
			lblFastdlUrl.Size = new System.Drawing.Size(69, 15);
			lblFastdlUrl.TabIndex = 0;
			lblFastdlUrl.Text = "FastDL URL:";
			// 
			// btnStart
			// 
			btnStart.Location = new System.Drawing.Point(134, 275);
			btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnStart.Name = "btnStart";
			btnStart.Size = new System.Drawing.Size(122, 35);
			btnStart.TabIndex = 4;
			btnStart.Text = "Start";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += btnStart_Click;
			// 
			// txtMaplistUrl
			// 
			txtMaplistUrl.Location = new System.Drawing.Point(108, 242);
			txtMaplistUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtMaplistUrl.Name = "txtMaplistUrl";
			txtMaplistUrl.Size = new System.Drawing.Size(268, 23);
			txtMaplistUrl.TabIndex = 3;
			// 
			// lblMaplistUrl
			// 
			lblMaplistUrl.AutoSize = true;
			lblMaplistUrl.Location = new System.Drawing.Point(14, 245);
			lblMaplistUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblMaplistUrl.Name = "lblMaplistUrl";
			lblMaplistUrl.Size = new System.Drawing.Size(79, 15);
			lblMaplistUrl.TabIndex = 2;
			lblMaplistUrl.Text = "Map List URL:";
			// 
			// lbServers
			// 
			lbServers.FormattingEnabled = true;
			lbServers.ItemHeight = 15;
			lbServers.Location = new System.Drawing.Point(14, 13);
			lbServers.Name = "lbServers";
			lbServers.Size = new System.Drawing.Size(362, 184);
			lbServers.TabIndex = 5;
			lbServers.SelectedIndexChanged += lbServers_SelectedIndexChanged;
			// 
			// FrmStartup
			// 
			AcceptButton = btnStart;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(391, 321);
			Controls.Add(lbServers);
			Controls.Add(txtMaplistUrl);
			Controls.Add(lblMaplistUrl);
			Controls.Add(txtFastdlUrl);
			Controls.Add(lblFastdlUrl);
			Controls.Add(btnStart);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "FrmStartup";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Map Downloader: Select Server";
			Load += frmStartup_Load;
			ResumeLayout(false);
			PerformLayout();
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