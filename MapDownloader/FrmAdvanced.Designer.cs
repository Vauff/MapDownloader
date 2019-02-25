namespace MapDownloader
{
    partial class FrmAdvanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdvanced));
            this.txtFastdlUrl = new System.Windows.Forms.TextBox();
            this.lblFastdlUrl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMaplistUrl = new System.Windows.Forms.TextBox();
            this.lblMaplistUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFastdlUrl
            // 
            this.txtFastdlUrl.Location = new System.Drawing.Point(93, 6);
            this.txtFastdlUrl.Name = "txtFastdlUrl";
            this.txtFastdlUrl.Size = new System.Drawing.Size(230, 20);
            this.txtFastdlUrl.TabIndex = 1;
            this.txtFastdlUrl.Text = "http://fastdl.gflclan.com/csgo/maps/";
            // 
            // lblFastdlUrl
            // 
            this.lblFastdlUrl.AutoSize = true;
            this.lblFastdlUrl.Location = new System.Drawing.Point(12, 9);
            this.lblFastdlUrl.Name = "lblFastdlUrl";
            this.lblFastdlUrl.Size = new System.Drawing.Size(69, 13);
            this.lblFastdlUrl.TabIndex = 0;
            this.lblFastdlUrl.Text = "FastDL URL:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMaplistUrl
            // 
            this.txtMaplistUrl.Location = new System.Drawing.Point(93, 32);
            this.txtMaplistUrl.Name = "txtMaplistUrl";
            this.txtMaplistUrl.Size = new System.Drawing.Size(230, 20);
            this.txtMaplistUrl.TabIndex = 3;
            this.txtMaplistUrl.Text = "https://raw.githubusercontent.com/Vauff/MapDownloader/master/maps.csv";
            // 
            // lblMaplistUrl
            // 
            this.lblMaplistUrl.AutoSize = true;
            this.lblMaplistUrl.Location = new System.Drawing.Point(12, 35);
            this.lblMaplistUrl.Name = "lblMaplistUrl";
            this.lblMaplistUrl.Size = new System.Drawing.Size(75, 13);
            this.lblMaplistUrl.TabIndex = 2;
            this.lblMaplistUrl.Text = "Map List URL:";
            // 
            // FrmAdvanced
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 94);
            this.Controls.Add(this.txtMaplistUrl);
            this.Controls.Add(this.lblMaplistUrl);
            this.Controls.Add(this.txtFastdlUrl);
            this.Controls.Add(this.lblFastdlUrl);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced";
            this.Load += new System.EventHandler(this.frmAdvanced_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFastdlUrl;
        private System.Windows.Forms.Label lblFastdlUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMaplistUrl;
        private System.Windows.Forms.Label lblMaplistUrl;
    }
}