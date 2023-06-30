using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapDownloader
{
	public partial class FrmStartup : Form
	{
		private WebClient client = new WebClient();
		private List<string> serverMapLists = new List<string>();
		private List<string> serverFastDLs = new List<string>();
		private List<string> serverAppIDs = new List<string>();
		private List<string> serverMapDirectories = new List<string>();

		public FrmStartup()
		{
			InitializeComponent();
		}

		private void frmStartup_Load(object sender, EventArgs e)
		{
			string json = "";

			try
			{
				json = client.DownloadString("https://raw.githubusercontent.com/Vauff/MapDownloader/master/servers.json");
			}
			catch (WebException)
			{
				MessageBox.Show("Failed retrieving the server list from MapDownloader GitHub!" + Environment.NewLine + Environment.NewLine + "Ensure github.com & your internet connection are functioning.", "Error");
				return;
			}

			using (JsonDocument document = JsonDocument.Parse(json))
			{
				JsonElement root = document.RootElement;
				JsonElement serversElement = root.GetProperty("servers");

				foreach (JsonElement server in serversElement.EnumerateArray())
				{
					lbServers.Items.Add(server.GetProperty("name").GetString());
					serverMapLists.Add(server.GetProperty("mapList").GetString());
					serverFastDLs.Add(server.GetProperty("fastDL").GetString());
					serverAppIDs.Add(server.GetProperty("appID").GetString());
					serverMapDirectories.Add(server.GetProperty("mapsDirectory").GetString());
				}
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (String.Equals(txtFastdlUrl.Text, "") || String.Equals(txtMaplistUrl.Text, "") || lbServers.SelectedIndex == -1)
			{
				MessageBox.Show("You must select a server!", "Error");
				return;
			}

			Global.fastdlUrl = txtFastdlUrl.Text;
			Global.maplistUrl = txtMaplistUrl.Text;
			Global.appID = serverAppIDs[lbServers.SelectedIndex];
			Global.mapsDirectory = serverMapDirectories[lbServers.SelectedIndex];

			Hide();
			FrmMain frmMain = new FrmMain();
			frmMain.Closed += (s, args) => this.Close();
			frmMain.Show();
		}

		private void lbServers_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtMaplistUrl.Text = serverMapLists[lbServers.SelectedIndex];
			txtFastdlUrl.Text = serverFastDLs[lbServers.SelectedIndex];
			txtMaplistUrl.SelectionStart = 0;
			txtFastdlUrl.SelectionStart = 0;
		}
	}
}
