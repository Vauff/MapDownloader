using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace MapDownloader
{
	public static class Functions
	{
        //https://stackoverflow.com/a/38604462
        public static void OpenBrowser(string url)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }); // Works ok on windows
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);  // Works ok on linux
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url); // Not tested
            }
        }

        public static string GetMapsDirectory()
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
                    string acfFile = folder + @"\steamapps\appmanifest_" + Global.appID + ".acf";

                    if (File.Exists(acfFile))
                    {
                        string installDir = File.ReadAllText(acfFile).Split(new string[] { "\"installdir\"		\"" }, StringSplitOptions.None)[1].Split('"')[0];

                        return folder.Substring(0, 1).ToUpper() + folder.Substring(1).Replace("program files", "Program Files") + @"\steamapps\common\" + installDir + Global.mapsDirectory;
                    }
                }
            }

            return "";
        }
    }
}
