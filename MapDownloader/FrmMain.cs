using ICSharpCode.SharpZipLib.BZip2;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapDownloader
{
    public partial class FrmMain : Form
    {
        public static string version = "1.0";
        public static string fastdlUrl = "http://fastdl.gflclan.com/csgo/maps/";
        public static string maplistUrl = "https://raw.githubusercontent.com/Vauff/MapDownloader/master/maps.csv";
        private WebClient client = new WebClient();
        private Queue<string> queue = new Queue<string>();
        private bool running = false;
        private int notDownloaded = 0;
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
            txtMapsDir.Text = GetMapsDirectory();
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

        private void tlsAdvanced_Click(object sender, EventArgs e)
        {
            FrmAdvanced frmAdvanced = new FrmAdvanced();
            frmAdvanced.ShowDialog();
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
            notDownloaded = 0;

            string[] mapList;
            List<string> downloadedMapList = new List<string>();
            List<string> toDownloadList = new List<string>();
            FileInfo[] mapFiles;

            txtOutput.Text = "";

            try
            {
                mapList = client.DownloadString(maplistUrl).Split(',');
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

            txtOutput.AppendText(mapList.Length + " total maps found in server map list");

            foreach (FileInfo file in mapFiles)
                downloadedMapList.Add(file.Name.Split('.')[0].ToLower());

            foreach (string rawMap in mapList)
            {
                string map = rawMap.Replace("\n", "");

                if (!downloadedMapList.Contains(map.Replace("$", "").ToLower()) && !map.Equals(""))
                    toDownloadList.Add(map);
            }

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
            notDownloaded = queue.Count;
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
                        client.DownloadFileAsync(new Uri(fastdlUrl + currentMap + ".bsp.bz2"), txtMapsDir.Text + currentMap + ".bsp.bz2");
                    else
                        client.DownloadFileAsync(new Uri(fastdlUrl + currentMap + ".bsp"), txtMapsDir.Text + currentMap + ".bsp");
                }
                catch (UriFormatException)
                {
                    txtOutput.AppendText(Environment.NewLine + "ERROR: Invalid FastDL URL provided");
                    ToggleMode(true);
                }
            }
            else
            {
                int processed = (toDownloadCount - notDownloaded);

                if (processed == 1)
                    txtOutput.AppendText(Environment.NewLine + "Successfully downloaded/extracted " + processed + " map");
                else
                    txtOutput.AppendText(Environment.NewLine + "Successfully downloaded/extracted " + processed + " maps");

                ToggleMode(true);
                btnMain.Enabled = true;
                prgDownload.Maximum = processed;
            }
        }

        private async void DownloadFinished(object sender, AsyncCompletedEventArgs e)
        {
            FileInfo compressedFile = new FileInfo(txtMapsDir.Text + currentMap + ".bsp.bz2");

            try
            {
                string x = e.Error.Message;

                txtOutput.AppendText(Environment.NewLine + currentMap + " download failed, make sure map name and other variables are correct");
                notDownloaded = queue.Count + 1;
                queue.Clear();
            }
            catch (Exception)
            {
                if (currentCompressed)
                {
                    FileStream compressedStream = compressedFile.OpenRead();
                    FileStream decompressedStream = File.Create(txtMapsDir.Text + currentMap + ".bsp");

                    txtOutput.AppendText(Environment.NewLine + "Extracting " + currentMap);
                    await Task.Run(() => BZip2.Decompress(compressedStream, decompressedStream, true));
                }

                prgDownload.PerformStep();
            }

            compressedFile.Delete();
            Download();
        }

        private string GetMapsDirectory()
        {
            string registryValue = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null);

            if (registryValue != null)
            {
                string libraryInfoFileContents = File.ReadAllText(registryValue.Replace("/", @"\") + @"\steamapps\libraryfolders.vdf");
                List<string> libraryFolders = new List<string>();

                for (int i = 1; true; i++)
                {
                    if (libraryInfoFileContents.Contains("\"" + i + "\""))
                        libraryFolders.Add(libraryInfoFileContents.Split(new string[] { "\"" + i + "\"		\"" }, StringSplitOptions.None)[1].Split('"')[0].Replace(@"\\", @"\"));
                    else
                        break;
                }

                libraryFolders.Add(registryValue.Replace("/", @"\"));

                foreach (string folder in libraryFolders)
                {
                    string acfFile = folder + @"\steamapps\appmanifest_730.acf";

                    if (File.Exists(acfFile))
                    {
                        string installDir = File.ReadAllText(acfFile).Split(new string[] { "\"installdir\"		\"" }, StringSplitOptions.None)[1].Split('"')[0];

                        return folder.Substring(0, 1).ToUpper() + folder.Substring(1).Replace("program files", "Program Files") + @"\steamapps\common\" + installDir + @"\csgo\maps\";
                    }
                }
            }

            return "";
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
            tlsAdvanced.Enabled = defaultState;
        }
    }
}