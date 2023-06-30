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
			btnMain = new System.Windows.Forms.Button();
			txtOutput = new System.Windows.Forms.TextBox();
			lblMapsDir = new System.Windows.Forms.Label();
			txtMapsDir = new System.Windows.Forms.TextBox();
			prgDownload = new System.Windows.Forms.ProgressBar();
			mnuMain = new System.Windows.Forms.MenuStrip();
			tlsAbout = new System.Windows.Forms.ToolStripMenuItem();
			btnBrowse = new System.Windows.Forms.Button();
			mnuMain.SuspendLayout();
			SuspendLayout();
			// 
			// btnMain
			// 
			btnMain.Location = new System.Drawing.Point(203, 69);
			btnMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnMain.Name = "btnMain";
			btnMain.Size = new System.Drawing.Size(122, 35);
			btnMain.TabIndex = 4;
			btnMain.Text = "Download Maps";
			btnMain.UseVisualStyleBackColor = true;
			btnMain.Click += btnMain_Click_Download;
			// 
			// txtOutput
			// 
			txtOutput.Location = new System.Drawing.Point(12, 111);
			txtOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtOutput.Multiline = true;
			txtOutput.Name = "txtOutput";
			txtOutput.ReadOnly = true;
			txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			txtOutput.Size = new System.Drawing.Size(501, 220);
			txtOutput.TabIndex = 5;
			txtOutput.TabStop = false;
			// 
			// lblMapsDir
			// 
			lblMapsDir.AutoSize = true;
			lblMapsDir.Location = new System.Drawing.Point(8, 43);
			lblMapsDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblMapsDir.Name = "lblMapsDir";
			lblMapsDir.Size = new System.Drawing.Size(90, 15);
			lblMapsDir.TabIndex = 1;
			lblMapsDir.Text = "Maps Directory:";
			// 
			// txtMapsDir
			// 
			txtMapsDir.Location = new System.Drawing.Point(110, 39);
			txtMapsDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtMapsDir.Name = "txtMapsDir";
			txtMapsDir.Size = new System.Drawing.Size(338, 23);
			txtMapsDir.TabIndex = 2;
			// 
			// prgDownload
			// 
			prgDownload.Location = new System.Drawing.Point(12, 338);
			prgDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			prgDownload.Name = "prgDownload";
			prgDownload.Size = new System.Drawing.Size(502, 27);
			prgDownload.TabIndex = 6;
			// 
			// mnuMain
			// 
			mnuMain.BackColor = System.Drawing.SystemColors.ControlLight;
			mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tlsAbout });
			mnuMain.Location = new System.Drawing.Point(0, 0);
			mnuMain.Name = "mnuMain";
			mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			mnuMain.Size = new System.Drawing.Size(527, 24);
			mnuMain.TabIndex = 0;
			mnuMain.Text = "menuStrip1";
			// 
			// tlsAbout
			// 
			tlsAbout.Name = "tlsAbout";
			tlsAbout.Size = new System.Drawing.Size(52, 20);
			tlsAbout.Text = "About";
			tlsAbout.Click += tlsAbout_Click;
			// 
			// btnBrowse
			// 
			btnBrowse.Location = new System.Drawing.Point(455, 39);
			btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnBrowse.Name = "btnBrowse";
			btnBrowse.Size = new System.Drawing.Size(58, 23);
			btnBrowse.TabIndex = 3;
			btnBrowse.Text = "Browse";
			btnBrowse.UseVisualStyleBackColor = true;
			btnBrowse.Click += btnBrowse_Click;
			// 
			// FrmMain
			// 
			AcceptButton = btnMain;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(527, 373);
			Controls.Add(btnBrowse);
			Controls.Add(prgDownload);
			Controls.Add(txtMapsDir);
			Controls.Add(lblMapsDir);
			Controls.Add(txtOutput);
			Controls.Add(btnMain);
			Controls.Add(mnuMain);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = mnuMain;
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "FrmMain";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Map Downloader";
			FormClosing += FrmMain_FormClosing;
			Load += FrmMain_Load;
			mnuMain.ResumeLayout(false);
			mnuMain.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
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

