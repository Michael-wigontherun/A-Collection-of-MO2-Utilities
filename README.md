# A Collection of MO2 Utilities
I will put all my smaller automation tools I make here. All of them don't strictly require MO2, but with these automation tools running them on top of your Data folder will have adverse effects. I will not assist people using other mod managers for this page. If you want to run these without MO2 unpack them into a separate folder then run over the separate folder. I still recommend using MO2 over any other thing for managing Bethesda Game Studio games.

## Installation
Install instructions are applied the same to all.
1. Download and Install .Net 6 Desktop Runtime.
2. Download and Whatever from here and unpack them to a folder. They can all sit nicely in the same folder.

## Usage Directions
For console Applications you can double click the exe to bring up the help menu or run it with the -help argument.
-help will also give you some more help for the -S= arguments.

### BodyslideGroupGenerator
Probably compatible with Fallout 4s Bodyslide.
You may need to run run this when the mod is updated, depending on if they change the names of the Bodyslide projects.
1. Edit "BodyslideGroupGenerator.bat".
2. -P="The folder containing your .osp Slider Sets" : This should be the folder at "[MO2 Mod]\CalienteTools\Bodyslide\SliderSets"
3. -O="Output Slider Groups Folder" : This should not be the same folder as the mod because it could be updated and you will need to re-run if the .xml is deleted
4. -N="Name of Output File without extension" : The name you want for the outputted .xml file. I like to use the name of the mod.
5. -S="CBBE" : Replace CBBE with what ever body group it should be.

### DARPriorityRemapper
1. Edit "DARPriorityRemapper.bat".
2. -P="Path to MO2 Mod" : Path to MO2 mod not a DAR folder
3. -S=".csv name or starting priority number" : Create a CSV anywhere you just need to add the path to it inside this argument. Or you could place a number in this arguement and it will iterate up from there on the priority.


## QA
Q: Why only MO2?
- A: That's because I use MO2. And making things for other mod managers when I don't use them I don't care to go back and forth with other people. On what they need to do.

Q: Why do you make such low effort Thumbnails?
- A: I have no artistic talent. My skills are with programming.
