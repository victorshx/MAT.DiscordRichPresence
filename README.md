# MAT.DiscordRichPresence

[![License](https://img.shields.io/github/license/victorshx/MAT.DiscordRichPresence.svg?label=License&maxAge=86400)](./LICENSE)
[![GitHub Release](https://img.shields.io/github/release/victorshx/MAT.DiscordRichPresence.svg?label=Latest&maxAge=60)](https://github.com/victorshx/MAT.DiscordRichPresence/releases/latest)
[![Github Downloads](https://img.shields.io/github/downloads/victorshx/MAT.DiscordRichPresence/latest/total.svg?label=Downloads%20for%20latest&maxAge=60)](https://github.com/victorshx/MAT.DiscordRichPresence/releases/latest)

<p align="center">
  <h2 align="center"><a href="https://github.com/victorshx/MAT.DiscordRichPresence/releases">DOWNLOAD HERE</a></h2>
</p>

MAT.DiscordRichPresence is an application developed to send rich presence update to your Discord for Mission Against Terror 2. Since the game has no intention of adding Discord Rich Presence, I thought we should do it ourselves.


MAT.DiscordRichPresence currently supports:

- Server Name
- Channel Name
- Room Number
- Number of players in a room
- Room Mode Name **(coming soon)**
- Room Map Name **(coming soon)**

Preview of the rich presence:

![Preview](https://i.imgur.com/v7DDIB8.jpeg)

![Preview](https://i.imgur.com/RaxxiwP.jpeg)

## Basic Usage  

This program is written to focus on simplicity. No configuration is required, just run and forget. However, Discord needs to be running for it to connect to Discord's Game Activity. 

If you are not seeing your presence, please enable **Display currently running game as a status message** under **Game Activity** at Discord settings. [Screenshot](https://i.imgur.com/LlUoFAc.jpg) of the settings.

Preview of the program: 

![Preview](https://i.imgur.com/WXJrU3j.jpeg)

## Requirements
- [.NET Framework 4.5.2](https://download.microsoft.com/download/9/A/7/9A78F13F-FD62-4F6D-AB6B-1803508A9F56/51209.34209.03/web/NDP452-KB2901954-Web.exe) (Please install it before running this program)
- Windows 10 (Windows 7, Windows 8 may work but is no longer tested, please upgrade)

## Branches ##

- [master] for production releases.
- [dev] for development.

## Build ##

If you have big brains, you can compile the program yourself.

## Credits

Created and maintained by victorshx ([@victorshx](https://github.com/victorshx)).

Reversing game structure by ([@buxkaizhe](https://github.com/buxkaizhe)), big thanks.

Providing SDK for game structure, couldn't do it without this guy ([@astron51](https://github.com/astron51)).

## License

`MAT.DiscordRichPresence` is available under the GPL 3.0 license. See the [LICENSE](LICENSE) file for more info.