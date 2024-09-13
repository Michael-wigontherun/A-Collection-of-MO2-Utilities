rmdir /s /q ".\Release Sets"
mkdir ".\Release Sets"

set CollectionReleaseSet= ".\Release Sets\A Collection of MO2 Utilities"
mkdir %CollectionReleaseSet%

set CollectionRAR= ".\Release Sets\A Collection of MO2 Utilities.rar"
set BodyslideGroupGeneratorRAR= ".\Release Sets\BodyslideGroupGenerator.rar"
set DARPriorityRAR= ".\Release Sets\DARPriority.rar"
set DetectFrameworkAPIRAR= ".\Release Sets\DetectFrameworkAPI.rar"
set zMergeEnablerRAR= ".\Release Sets\Enable_zMerged_Disabled_Plugins.rar"
set CombineFoldersRAR= ".\Release Sets\CombineFolders.rar"
set RemoveEntriesFromListsRAR= ".\Release Sets\RemoveEntriesFromLists.rar"
set DetectFormLinksInRecordsRAR= ".\Release Sets\DetectFormLinksInRecords.rar"
set DetectProblematicRecordsForMutagenRAR= ".\Release Sets\DetectProblematicRecordsForMutagen.rar"
set MainMenuRandomizerAssistantRAR= ".\Release Sets\MainMenuRandomizerAssistant.rar"
set MainMenuRandomizerAssistantRAR= ".\Release Sets\MainMenuRandomizerAssistant.rar"
set ScriptEditorRAR= ".\Release Sets\ScriptEditor.rar"
set PluginCheckerForMergeRAR= ".\Release Sets\PluginCheckerForMerge.rar"

del /q %CollectionRAR%
del /q %BodyslideGroupGeneratorRAR%
del /q %DARPriorityRAR%
del /q %DetectFrameworkAPIRAR%
del /q %zMergeEnablerRAR%
del /q %CombineFoldersRAR%
del /q %RemoveEntriesFromListsRAR%
del /q %DetectProblematicRecordsForMutagenRAR%
del /q %MainMenuRandomizerAssistantRAR%
del /q %ScriptEditorRAR%
del /q %PluginCheckerForMergeRAR%

set BodyslideGroupGeneratorReleaseSet= ".\Release Sets\BodyslideGroupGenerator"
mkdir %BodyslideGroupGeneratorReleaseSet%
xcopy /s /y ".\BodyslideGroupGenerator\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\BodyslideGroupGenerator\bin\Release\net6.0" %BodyslideGroupGeneratorReleaseSet%

set DARPriorityReleaseSet= ".\Release Sets\DARPriority"
mkdir %DARPriorityReleaseSet%
xcopy /s /y ".\DARPriorityRemapper\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\DARPriorityRemapper\bin\Release\net6.0" %DARPriorityReleaseSet%

set DetectFrameworkAPIReleaseSet= ".\Release Sets\DetectFrameworkAPI"
mkdir %DetectFrameworkAPIReleaseSet%
xcopy /s /y ".\DetectFrameworkAPI\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\DetectFrameworkAPI\FrameworkLists" ".\Release Sets\A Collection of MO2 Utilities\FrameworkLists"
xcopy /s /y ".\DetectFrameworkAPI\bin\Release\net6.0" %DetectFrameworkAPIReleaseSet%
xcopy /s /y ".\DetectFrameworkAPI\FrameworkLists" ".\Release Sets\DetectFrameworkAPI\FrameworkLists"

set zMergeEnablerReleaseSet= ".\Release Sets\Enable_zMerged_Disabled_Plugins"
mkdir %zMergeEnablerReleaseSet%
xcopy /s /y ".\Enable_zMerged_Disabled_Plugins\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\Enable_zMerged_Disabled_Plugins\bin\Release\net6.0" %zMergeEnablerReleaseSet%

set CombineFoldersReleaseSet= ".\Release Sets\CombineFolders"
mkdir %CombineFoldersReleaseSet%
xcopy /s /y ".\CombineFolders\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\CombineFolders\bin\Release\net6.0" %CombineFoldersReleaseSet%

set RemoveEntriesFromListsReleaseSet= ".\Release Sets\RemoveEntriesFromLists"
mkdir %RemoveEntriesFromListsReleaseSet%
xcopy /s /y ".\RemoveEntriesFromLists\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\RemoveEntriesFromLists\bin\Release\net6.0" %RemoveEntriesFromListsReleaseSet%

set DetectFormLinksInRecordsReleaseSet= ".\Release Sets\DetectFormLinksInRecords"
mkdir %DetectFormLinksInRecordsReleaseSet%
xcopy /s /y ".\DetectFormLinksInRecords\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\DetectFormLinksInRecords\bin\Release\net6.0" %DetectFormLinksInRecordsReleaseSet%

set DetectProblematicRecordsForMutagenReleaseSet= ".\Release Sets\DetectProblematicRecordsForMutagen"
mkdir %DetectProblematicRecordsForMutagenReleaseSet%
xcopy /s /y ".\DetectProblematicRecordsForMutagen\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\DetectProblematicRecordsForMutagen\bin\Release\net6.0" %DetectProblematicRecordsForMutagenReleaseSet%

set MainMenuRandomizerAssistantReleaseSet= ".\Release Sets\MainMenuRandomizerAssistant"
mkdir %MainMenuRandomizerAssistantReleaseSet%
xcopy /s /y ".\MainMenuRandomizerAssistant\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\MainMenuRandomizerAssistant\bin\Release\net6.0" %MainMenuRandomizerAssistantReleaseSet%

set ScriptEditorReleaseSet= ".\Release Sets\ScriptEditor"
mkdir %ScriptEditorReleaseSet%
xcopy /s /y ".\ScriptEditor\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\ScriptEditor\bin\Release\net6.0" %ScriptEditorReleaseSet%

set PluginCheckerForMergeSet= ".\Release Sets\PluginCheckerForMerge"
mkdir %PluginCheckerForMergeSet%
xcopy /s /y ".\PluginCheckerForMerge\bin\Release\net6.0" %CollectionReleaseSet%
xcopy /s /y ".\PluginCheckerForMerge\bin\Release\net6.0" %PluginCheckerForMergeSet%


"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %CollectionRAR% %CollectionReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %BodyslideGroupGeneratorRAR% %BodyslideGroupGeneratorReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %DARPriorityRAR% %DARPriorityReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %DetectFrameworkAPIRAR% %DetectFrameworkAPIReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %zMergeEnablerRAR% %zMergeEnablerReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %CombineFoldersRAR% %CombineFoldersReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %RemoveEntriesFromListsRAR% %RemoveEntriesFromListsReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %DetectFormLinksInRecordsRAR% %DetectFormLinksInRecordsReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %DetectProblematicRecordsForMutagenRAR% %DetectProblematicRecordsForMutagenReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %MainMenuRandomizerAssistantRAR% %MainMenuRandomizerAssistantReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %ScriptEditorRAR% %ScriptEditorReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %PluginCheckerForMergeRAR% %PluginCheckerForMergeSet%

explorer.exe ".\Release Sets"

personalCopy.bat