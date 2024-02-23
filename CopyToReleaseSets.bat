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

del /q %CollectionRAR%
del /q %BodyslideGroupGeneratorRAR%
del /q %DARPriorityRAR%
del /q %DetectFrameworkAPIRAR%
del /q %zMergeEnablerRAR%
del /q %CombineFoldersRAR%
del /q %RemoveEntriesFromListsRAR%

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

"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %CollectionRAR% %CollectionReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %BodyslideGroupGeneratorRAR% %BodyslideGroupGeneratorReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %DARPriorityRAR% %DARPriorityReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %DetectFrameworkAPIRAR% %DetectFrameworkAPIReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %zMergeEnablerRAR% %zMergeEnablerReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %CombineFoldersRAR% %CombineFoldersReleaseSet%
"C:\Program Files\WinRAR\WinRAR.exe" a -s -ep1 %RemoveEntriesFromListsRAR% %RemoveEntriesFromListsReleaseSet%

explorer.exe ".\Release Sets"

personalCopy.bat