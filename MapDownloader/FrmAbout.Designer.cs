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
			this.picVauff = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblAbout = new System.Windows.Forms.Label();
			this.lblLink = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.picVauff)).BeginInit();
			this.SuspendLayout();
			// 
			// picVauff
			// 
			this.picVauff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVauff.BackgroundImage")));
			this.picVauff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picVauff.Location = new System.Drawing.Point(6, 14);
			this.picVauff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.picVauff.Name = "picVauff";
			this.picVauff.Size = new System.Drawing.Size(173, 171);
			this.picVauff.TabIndex = 0;
			this.picVauff.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(264, 153);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(98, 31);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.Location = new System.Drawing.Point(237, 12);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(129, 20);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Map Downloader";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Location = new System.Drawing.Point(294, 35);
			this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(13, 15);
			this.lblVersion.TabIndex = 3;
			this.lblVersion.Text = "x";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblAbout
			// 
			this.lblAbout.AutoSize = true;
			this.lblAbout.Location = new System.Drawing.Point(188, 59);
			this.lblAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAbout.Name = "lblAbout";
			this.lblAbout.Size = new System.Drawing.Size(13, 15);
			this.lblAbout.TabIndex = 4;
			this.lblAbout.Text = "x";
			// 
			// lblLink
			// 
			this.lblLink.AutoSize = true;
			this.lblLink.Location = new System.Drawing.Point(189, 127);
			this.lblLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLink.Name = "lblLink";
			this.lblLink.Size = new System.Drawing.Size(234, 15);
			this.lblLink.TabIndex = 5;
			this.lblLink.TabStop = true;
			this.lblLink.Text = "https://github.com/Vauff/MapDownloader";
			this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
			// 
			// FrmAbout
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(438, 198);
			this.Controls.Add(this.lblLink);
			this.Controls.Add(this.lblAbout);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.picVauff);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "FrmAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.Load += new System.EventHandler(this.FrmAbout_Load);
			((System.ComponentModel.ISupportInitialize)(this.picVauff)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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