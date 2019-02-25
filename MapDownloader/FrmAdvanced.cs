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
    public partial class FrmAdvanced : Form
    {
        public FrmAdvanced()
        {
            InitializeComponent();
        }

        private void frmAdvanced_Load(object sender, EventArgs e)
        {
            txtFastdlUrl.Text = FrmMain.fastdlUrl;
            txtMaplistUrl.Text = FrmMain.maplistUrl;
            txtFastdlUrl.SelectionStart = 0;
            txtMaplistUrl.SelectionStart = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmMain.fastdlUrl = txtFastdlUrl.Text;
            FrmMain.maplistUrl = txtMaplistUrl.Text;
            Close();
        }
    }
}
