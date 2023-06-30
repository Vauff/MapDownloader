using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ValveKeyValue;

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

            // Only works on Windows, Mac/Linux users will need to manually browse for the folder
            if (registryValue != null)
            {
				KVSerializer serializer = KVSerializer.Create(KVSerializationFormat.KeyValues1Text);
				KVObject libraryFoldersKV = serializer.Deserialize(File.OpenRead(registryValue.Replace("/", @"\") + @"\steamapps\libraryfolders.vdf"));

                foreach (KVObject folder in libraryFoldersKV)
                {
                    string folderPath = folder["path"].ToString();

                    // Clean up some cosmetic formatting changes Steam can make
                    folderPath = folderPath.Substring(0, 1).ToUpper() + folderPath.Substring(1).Replace("program files", "Program Files").Replace(@"\\", @"\");

					string acfFile = folderPath + @"\steamapps\appmanifest_" + Global.appID + ".acf";

					if (File.Exists(acfFile))
					{
						KVObject appManifestKV = serializer.Deserialize(File.OpenRead(acfFile));
						string installDir = appManifestKV["installdir"].ToString();

						return folderPath + @"\steamapps\common\" + installDir + Global.mapsDirectory;
					}
				}
            }

            return "";
        }
    }
}
