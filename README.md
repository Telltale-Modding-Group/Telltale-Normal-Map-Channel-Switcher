# Telltale-Normal-Map-Channel-Switcher
A very simple Unity-based tool to switch .png image channels from ABGR format to RGBA. Created to be used on normal maps found in certain games developed by Telltale (Seasons 1-3 of TWD, for example) for the purpose of editing or extracting.
![alt text](https://github.com/Telltale-Modding-Group/Telltale-Normal-Map-Channel-Switcher/blob/main/screenshots/ex.png?raw=true)
## How to use
1) Put the .png textures into the Build\textures folder.
2) Run TextureChannelSwitcher.exe, wait for it for it to finish switching the channels.
3) Close TextureChannelSwitcher.exe.

## How to prepare textures
This tool only works with .png format. There are several ways you can use to get them there.
1) IF YOU WORK WITH TWD DEFINITIVE SERIES: You can extract the textures in their raw .d3dtx format (using ttarchext or Telltale Explorer) and then use the Texture Tool CLI Beta 2.0.1+ (https://github.com/Telltale-Modding-Group/DDS-D3DTX-Converter) to turn them into .dds. Then you can use Paint.net or any other tool to turn the .dds textures into .png.
2) Alternatively, you can use Telltale Explorer to extract them into .dds directly. The .dds files created by Telltale Explorer appear to have issues with .png convertion using certain tools, so keep that in mind. DO NOT use Telltale Explorer to extract the textures directly into .png format, the Telltale Explorer .png export is bugged and you will lose the Alpha channel. The Alpha channel of these normal maps contains crucial information, and losing it will mean you won't get the correct results.
3) You can also use Telltale Inspector (https://github.com/LucasSaragosa/TelltaleInspector) to convert the textures directly to .png. As far as I know, this method should not cause any issues with Alpha, but I have not personally tested it yet.
