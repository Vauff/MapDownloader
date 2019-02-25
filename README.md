# Map Downloader

Map Downloader is a tool created to automate the mass downloading of the maps on the GFL ZE server. It eases the process by automatically figuring out what maps from the servers nomination list aren't downloaded, and downloading/extracting them to your CS:GO maps folder. This can help avoid join delays and having to rejoin for particles when playing a new map.

The programs design/concept is based off a similar tool made by Neon located [here](https://unloze.com/threads/cs-s-ze-map-pack.396/). I just decided that I wanted to make one that took the concept further with neat features like inbuilt extraction, automatic game folder detection and configurable FastDL/map list links.

## Can I Use This For My Server?

While this tool is built for use with the GFL ZE server, the map list and FastDL URL are 100% configurable and maps can be downloaded for any server with a maintained map list. However, you may want to consider forking the project if offering this as an official thing, because values default to links for GFL ZE and the program is also branded that way.

The format for any custom map list just needs to be a CSV (comma separated values) map list with a $ symbol prefixing any map not using .bz2 format in the FastDL (likely maps > 150 MB). You can view the default map list for GFL ZE as an example [here](https://raw.githubusercontent.com/Vauff/MapDownloader/master/maps.csv).