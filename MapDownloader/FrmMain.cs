using ICSharpCode.SharpZipLib.BZip2;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapDownloader
{
	public partial class FrmMain : Form
	{
		private WebClient client = new WebClient();
		private Queue<string> queue = new Queue<string>();
		private bool running = false;
		private int processed = 0;
		private int toDownloadCount;
		private string currentMap;
		private bool currentCompressed;

		public FrmMain()
		{
			InitializeComponent();
			client.DownloadFileCompleted += DownloadFinished;
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			txtMapsDir.Text = Functions.GetMapsDirectory();
			txtMapsDir.SelectionStart = 0;
		}

		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (running)
			{
				if (MessageBox.Show("A download process is currently running, are you sure you want to exit?" + Environment.NewLine + Environment.NewLine + "Exiting while a process is running could result in map file corruption", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
		}

		private void tlsAbout_Click(object sender, EventArgs e)
		{
			FrmAbout frmAbout = new FrmAbout();
			frmAbout.ShowDialog();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
				txtMapsDir.Text = dialog.SelectedPath + "\\";
		}

		private void btnMain_Click_Download(object sender, EventArgs e)
		{
			ToggleMode(false);
			processed = 0;

			string[] mapList;
			List<string> realMapList = new List<string>();
			List<string> downloadedMapList = new List<string>();
			List<string> toDownloadList = new List<string>();
			FileInfo[] mapFiles;

			txtOutput.Text = "";

			try
			{
				ServicePointManager.ServerCertificateValidationCallback += (o, certificate, chain, errors) => true;
				mapList = client.DownloadString(Global.maplistUrl).Split(',');
			}
			catch (WebException)
			{
				txtOutput.AppendText("ERROR: Invalid map list URL provided");
				ToggleMode(true);
				return;
			}

			try
			{
				mapFiles = new DirectoryInfo(txtMapsDir.Text).GetFiles("*.bsp");
			}
			catch (Exception)
			{
				txtOutput.AppendText("ERROR: Invalid maps directory provided");
				ToggleMode(true);
				return;
			}

			foreach (FileInfo file in mapFiles)
				downloadedMapList.Add(file.Name.Split('.')[0].ToLower());

			foreach (string rawMap in mapList)
			{
				string map = rawMap.Replace("\r\n", "").Replace("\n", "");

				if (!map.Equals(""))
				{
					realMapList.Add(map);

					if (!downloadedMapList.Contains(map.Replace("$", "").ToLower()))
						toDownloadList.Add(map);
				}
			}

			txtOutput.AppendText(realMapList.Count + " total maps found in server map list");

			toDownloadCount = toDownloadList.Count;
			prgDownload.Maximum = toDownloadCount;
			prgDownload.Value = 0;
			prgDownload.Step = 1;

			if (toDownloadCount != 0)
			{
				if (toDownloadCount == 1)
					txtOutput.AppendText(Environment.NewLine + "Maps directory missing " + toDownloadCount + " map from the map list, marking it for download...");
				else
					txtOutput.AppendText(Environment.NewLine + "Maps directory missing " + toDownloadCount + " maps from the map list, marking them for download...");

				foreach (string map in toDownloadList)
					queue.Enqueue(map);

				Download();
			}
			else
			{
				txtOutput.AppendText(Environment.NewLine + "All maps already downloaded and up to date!");
				ToggleMode(true);
			}
		}

		private void btnMain_Click_Stop(object sender, EventArgs e)
		{
			txtOutput.AppendText(Environment.NewLine + "Stop request received, process will stop after the current map is finished");
			btnMain.Enabled = false;
			queue.Clear();
		}

		private void Download()
		{
			if (queue.Count > 0)
			{
				currentMap = queue.Dequeue();

				if (currentMap.StartsWith("$"))
				{
					currentMap = currentMap.Replace("$", "");
					currentCompressed = false;
				}
				else
				{
					currentCompressed = true;
				}

				txtOutput.AppendText(Environment.NewLine + "Downloading " + currentMap);

				try
				{
					if (currentCompressed)
						client.DownloadFileAsync(new Uri(Global.fastdlUrl + currentMap + ".bsp.bz2"), txtMapsDir.Text + currentMap + ".bsp.bz2");
					else
						client.DownloadFileAsync(new Uri(Global.fastdlUrl + currentMap + ".bsp"), txtMapsDir.Text + currentMap + ".bsp");
				}
				catch (UriFormatException)
				{
					txtOutput.AppendText(Environment.NewLine + "ERROR: Invalid FastDL URL provided");
					ToggleMode(true);
				}
			}
			else
			{
				if (processed == 1)
					txtOutput.AppendText(Environment.NewLine + "Successfully downloaded/extracted " + processed + " map");
				else
					txtOutput.AppendText(Environment.NewLine + "Successfully downloaded/extracted " + processed + " maps");

				ToggleMode(true);
				btnMain.Enabled = true;
				prgDownload.Maximum = processed;

				FlashWindow.Flash(this);
			}
		}

		private async void DownloadFinished(object sender, AsyncCompletedEventArgs e)
		{
			FileInfo compressedFile = new FileInfo(txtMapsDir.Text + currentMap + ".bsp.bz2");

			try
			{
				string x = e.Error.Message;

				txtOutput.AppendText(Environment.NewLine + currentMap + " download failed");
			}
			catch (Exception)
			{
				if (currentCompressed)
				{
					FileStream compressedStream = compressedFile.OpenRead();
					FileStream decompressedStream = File.Create(txtMapsDir.Text + currentMap + ".bsp");

					txtOutput.AppendText(Environment.NewLine + "Extracting " + currentMap);
					await Task.Run(() => BZip2.Decompress(compressedStream, decompressedStream, true));
					processed++;
				}
			}

			prgDownload.PerformStep();

			if (compressedFile.Exists)
				compressedFile.Delete();

			Download();
		}

		private void ToggleMode(bool defaultState)
		{
			if (defaultState)
			{
				btnMain.Text = "Download Maps";
				this.btnMain.Click -= new EventHandler(this.btnMain_Click_Stop);
				this.btnMain.Click += new EventHandler(this.btnMain_Click_Download);
			}
			else
			{
				btnMain.Text = "Stop";
				this.btnMain.Click -= new EventHandler(this.btnMain_Click_Download);
				this.btnMain.Click += new EventHandler(this.btnMain_Click_Stop);
			}

			running = !defaultState;
			btnBrowse.Enabled = defaultState;
			txtMapsDir.Enabled = defaultState;
		}
	}
}