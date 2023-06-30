using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapDownloader
{
	public partial class FrmAbout : Form
	{
		public FrmAbout()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FrmAbout_Load(object sender, EventArgs e)
		{
			lblVersion.Text = "v" + Global.version;
			lblAbout.Text = "Created by Vauff" + Environment.NewLine + Environment.NewLine + "Licensed under the GNU General Public" + Environment.NewLine + "License v3.0";
		}

		private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			lblLink.LinkVisited = true;
			Functions.OpenBrowser("https://github.com/Vauff/MapDownloader");
		}
	}
}
