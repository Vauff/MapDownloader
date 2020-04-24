# Map Downloader

![Demo Picture](https://i.imgur.com/yT0XbUT.png "Demo Picture")

Map Downloader is a tool created to automate the mass downloading of servers map lists. It eases the process by automatically figuring out what maps from the servers nomination list aren't downloaded, and downloading/extracting them to your games maps folder. This can help avoid join delays and having to rejoin for particles when playing a new map.

The programs design/concept is based off a similar tool made by Neon located [here](https://unloze.com/threads/cs-s-ze-map-pack.396/). I just decided that I wanted to make one that took the concept further with neat features like inbuilt extraction, automatic game folder detection and configurable FastDL/map list links.

## Can I Use This For My Server?

Yes! The program is built to read servers dynamically from [servers.json](https://github.com/Vauff/MapDownloader/blob/master/servers.json) and will update for anyone with the program immediately after changes happen. To have your server added here, you simply need to add a new server object and provide the given fields. You can either PR a server addition, or contact me directly if you are unfamiliar with GitHub. Servers with dead FastDL or map list URL's will be removed after some time.

The map list must be an online hosted URL (to support the dynamically updating nature of the program), where you choose to host it is up to you. The format for any custom map list just needs to be a CSV (comma separated values) map list with a $ symbol prefixing any map not using .bz2 format in the FastDL (likely maps > 150 MB). You can view the map list for GFL ZE as an example [here](https://vauff.com/gfl-ze-maps.csv).

## Requirements

**Windows:** None

**Mac/Linux:** [Wine](https://www.winehq.org/), unfortunately I realized late in development that the cross-platform support of .NET Core did not extend to forms. However, I have tested the program in Wine myself and did not spot any issues.