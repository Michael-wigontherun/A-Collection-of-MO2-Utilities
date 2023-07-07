mkdir ".\Release Sets"
mkdir ".\Release Sets\A Collection of MO2 Utilities"
mkdir ".\Release Sets\BodyslideGroupGenerator"
xcopy /s /y ".\BodyslideGroupGenerator\bin\Release\net6.0" ".\Release Sets\A Collection of MO2 Utilities"
xcopy /s /y ".\BodyslideGroupGenerator\bin\Release\net6.0" ".\Release Sets\BodyslideGroupGenerator"

mkdir ".\Release Sets\DARPriorityReader"
xcopy /s /y ".\DARPriorityReader\bin\Release\net6.0" ".\Release Sets\A Collection of MO2 Utilities"
xcopy /s /y ".\DARPriorityReader\bin\Release\net6.0" ".\Release Sets\DARPriorityReader"

mkdir ".\Release Sets\DARPriorityRemapper"
xcopy /s /y ".\DARPriorityRemapper\bin\Release\net6.0" ".\Release Sets\A Collection of MO2 Utilities"
xcopy /s /y ".\DARPriorityRemapper\bin\Release\net6.0" ".\Release Sets\DARPriorityRemapper"