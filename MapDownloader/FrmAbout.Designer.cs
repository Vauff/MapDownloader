namespace MapDownloader
{
	partial class FrmAbout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
			picVauff = new System.Windows.Forms.PictureBox();
			btnClose = new System.Windows.Forms.Button();
			lblTitle = new System.Windows.Forms.Label();
			lblVersion = new System.Windows.Forms.Label();
			lblAbout = new System.Windows.Forms.Label();
			lblLink = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)picVauff).BeginInit();
			SuspendLayout();
			// 
			// picVauff
			// 
			picVauff.BackgroundImage = (System.Drawing.Image)resources.GetObject("picVauff.BackgroundImage");
			picVauff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			picVauff.Location = new System.Drawing.Point(6, 14);
			picVauff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			picVauff.Name = "picVauff";
			picVauff.Size = new System.Drawing.Size(173, 171);
			picVauff.TabIndex = 0;
			picVauff.TabStop = false;
			// 
			// btnClose
			// 
			btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			btnClose.Location = new System.Drawing.Point(264, 153);
			btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnClose.Name = "btnClose";
			btnClose.Size = new System.Drawing.Size(98, 31);
			btnClose.TabIndex = 1;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			lblTitle.Location = new System.Drawing.Point(237, 12);
			lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new System.Drawing.Size(129, 20);
			lblTitle.TabIndex = 2;
			lblTitle.Text = "Map Downloader";
			// 
			// lblVersion
			// 
			lblVersion.AutoSize = true;
			lblVersion.Location = new System.Drawing.Point(294, 35);
			lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblVersion.Name = "lblVersion";
			lblVersion.Size = new System.Drawing.Size(13, 15);
			lblVersion.TabIndex = 3;
			lblVersion.Text = "x";
			lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblAbout
			// 
			lblAbout.AutoSize = true;
			lblAbout.Location = new System.Drawing.Point(188, 59);
			lblAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblAbout.Name = "lblAbout";
			lblAbout.Size = new System.Drawing.Size(13, 15);
			lblAbout.TabIndex = 4;
			lblAbout.Text = "x";
			// 
			// lblLink
			// 
			lblLink.AutoSize = true;
			lblLink.Location = new System.Drawing.Point(189, 127);
			lblLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblLink.Name = "lblLink";
			lblLink.Size = new System.Drawing.Size(234, 15);
			lblLink.TabIndex = 5;
			lblLink.TabStop = true;
			lblLink.Text = "https://github.com/Vauff/MapDownloader";
			lblLink.LinkClicked += lblLink_LinkClicked;
			// 
			// FrmAbout
			// 
			AcceptButton = btnClose;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			CancelButton = btnClose;
			ClientSize = new System.Drawing.Size(438, 198);
			Controls.Add(lblLink);
			Controls.Add(lblAbout);
			Controls.Add(lblVersion);
			Controls.Add(lblTitle);
			Controls.Add(btnClose);
			Controls.Add(picVauff);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "FrmAbout";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "About";
			Load += FrmAbout_Load;
			((System.ComponentModel.ISupportInitialize)picVauff).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.PictureBox picVauff;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblAbout;
		private System.Windows.Forms.LinkLabel lblLink;
	}
}