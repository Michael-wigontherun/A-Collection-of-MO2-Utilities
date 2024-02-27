# A Collection of MO2 Utilities
I will put all my smaller automation tools I make here. All of them don't strictly require MO2, but with these automation tools running them on top of your Data folder could have adverse effects. I will not assist people using other mod managers for this page. If you want to run these without MO2 unpack them into a separate folder then run over the separate folder. I still recommend using MO2 over any other thing for managing Bethesda Game Studio games.

I will take small requests and if I like the idea I'll build something, just create a new topic in the Forum tab on this page.

## Installation
Install instructions are applied the same to all.
1. Download and Install .Net 6 Desktop Runtime.
2. Download and Whatever from here and unpack them to a folder. They can all sit nicely in the same folder.

## Usage Directions
For console Applications you can double click the exe to bring up the help menu or run them with the -help argument.
-help will also give you some more help for the -S= arguments.
Duplicating and renaming the bat files will prevent them from being overwritten when updating.

## BodyslideGroupGenerator
This will generate a Bodyslide SliderGroup from a folder of .osp files
Probably compatible with Fallout 4s Bodyslide.

### BodyslideGroupGenerator
You may need to run run this when the mod is updated, depending on if they change the names of the Bodyslide projects.
1. Edit "BodyslideGroupGenerator.bat".
2. -P="The folder containing your .osp Slider Sets" : This should be the folder at "[MO2 Mod]\CalienteTools\Bodyslide\SliderSets"
3. -O="Output Slider Groups Folder" : This should not be the same folder as the mod because it could be updated and you will need to re-run if the .xml is deleted
4. -N="Name of Output File without extension" : The name you want for the outputted .xml file. I like to use the name of the mod.
5. -S="CBBE" : Replace CBBE with what ever body group it should be.

## Enable_zMerged_Disabled_Plugins
Enables plugins in the load order based off of a zMerge merge.json
Compatible with Fallout 4.

### Enable_zMerged_Disabled_Plugins
This could be used by other Mod Managers
1. Edit "Enable_zMerged_Disabled_Plugins.bat"
2. -P="File Path directly to a merge.json" : merge.json's are the files inside a "Merge - YourMerge" folder
3. -S="Path to a plugins.txt" : This can be in a MO2 Profile Folder or inside your Local AppData, If you are a MO2 user and you set it to the Local AppData, you must run the Bat through MO2

## DARPriority
Two tools to assist with remapping DAR Mods, similar to my [OAR Priority tool](https://www.nexusmods.com/skyrimspecialedition/mods/93992) except for DAR

### DARPriorityReader
This will read and report all DAR priorities inside MO2 Mod folder
This does not edit anything so its fine to run over top of the data folder and will report each DAR priority is used in your entire load order, could be useful for finding folders that wont conflict with other mods
1. Edit "DARPriorityReader.bat"
2. -P="Path to MO2 Mod or to Skyrim's Data folder" : Path to MO2 mod not a DAR folder or to Skyrim's Data folder

### DARPriorityRemapper
This will remap DAR Priorities based off csv files generated by DARPriorityReader
1. Edit "DARPriorityRemapper.bat".
2. -P="Path to MO2 Mod" : Path to MO2 mod not a DAR folder
3. -S=".csv name or starting priority number" : Create a CSV anywhere you just need to add the path to it inside this argument. Or you could place a number in this argument and it will iterate up from there on the priority.

## DetectFrameworkAPI
Two tools to help diagnose what mods are needed for another mods script files.
Compatible with Fallout 4, but you should create a second instance without the base FrameworkLists files.

### APIReader
This will read and export a FrameworkAPI file for DetectFrameworkAPI to read and compare in mods
This should not be run over the data folder. Adding every script to a API isn't a API and will result in nothing not gaining any useful information.
1. Edit "APIReader.bat"
2. -P="MO2 Mod folder or source scripts folder in a MO2 Mod folder" : This looks for the .pex or .psc files to add to an API file
3. -N="Name of the API" : Mod Name works fine for this

### DetectFrameworkAPI
This will create a report of a MO2 mod folder by comparing FrameworkAPI files generated by the APIReader
This does not edit anything so its fine to run over top of the data folder. However it will result in random-ish output that isn't really useful
1. Edit "DetectFrameworkAPI.bat"
2. -P="MO2 Mod folder or source scripts folder in a MO2 Mod folder" : This looks for the .psc files to read so any folder or root folder works.

## RemoveEntriesFromLists
This will run over a specified plugin and remove any entries from LevelLists, Containers, and 
This will run on a single plugin. It will touch nothing but that one plugin.

### RemoveEntriesFromListsFormLists
1. Edit "RemoveEntriesFromLists.bat"
2. -P="Path to plugin needing to be cleaned" : Absolute path directly to the plugin you wish to clean
3. -S="List of plugins names separated with , that should be removed from any list in the plugin" : This can be a list, Examples:

    -S="aMidianBorn_ContentAddon.esp"

    -S="aMidianBorn_ContentAddon.esp, OWL_AMB_CA_Patch.esp"

## CombineFolders
This will combine folders from separated folders. This will help with those annoying FOMODs that still do not have plugin detection or you just want all the options.

### CombineFolders
1. Edit "Run CombineFolders.bat"
2. -P="Folder Start path to search" : Path to base folder
3. -O="Path to output to" : Folder you want the files output to, you can remove this if you want the base folder to also be the output folder
4. -S="Name of folder(s) to search for" : Folders you want copied

## DetectProblematicRecordsForMutagen
This is a diagnostic tool to detect Records that can not be read Mutagen and can crash Mutagen based programs, like Synthesis or other Programs I have made using Mutagen.
It will give you a list of records that are problematic for you to locate using xEdit.

Do not tell me about errors this reports I can do nothing about them as it has to do with your plugins. It is designed to find and report errors. Fix your plugins yourself.

### DetectProblematicRecordsForMutagen
1. Edit "Run DetectProblematicRecordsForMutagen.bat"
2. -P="Path to plugin" : The path to the plugin you suspect has an issue.

## DetectFormLinksInRecords
This will detect any and all FormLinks inside your plugin and report them as a yaml file.
This helps with removing master files from plugins. As it will tell you exactly which records are linked in a plugin so you can open it in xEdit and delete them manually.
I will not add any kind of automatic deletion function to this.

### DetectFormLinksInRecords
1. Edit "Run DetectFormLinksInRecords.bat"
2. -P="Path to plugin" : The path to the plugin you wish to have a report on
3. Extra sorting can be done with the -S= argument.
    Example: -S="doublejump.esp".
    Example: -S="doublejump.esp, INIGO.esp".

## QA
Q: Why only MO2?
A: That's because I use MO2. And making things for other mod managers when I don't use them I don't care to go back and forth with other people. On what they need to do.

Q: Why do you make such low effort Thumbnails?
A: I have no artistic talent. My skills are with programming.
