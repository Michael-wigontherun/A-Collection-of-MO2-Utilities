rem | Set to path of the compiler
rem | Example: Skyrim Special Edition\Papyrus Compiler\PapyrusCompiler.exe
set compiler=

rem ----------------------------------------------------------------------------------------------------------------------------------
rem | Set to path of the scripts you edited
rem | Example: EditedModFolder\source\scripts
set changedScripts=

rem ----------------------------------------------------------------------------------------------------------------------------------
rem | flg file name with extention if your using this for skyrim you do not need to change this
rem | Example: TESV_Papyrus_Flags.flg
set flg=TESV_Papyrus_Flags.flg

rem ----------------------------------------------------------------------------------------------------------------------------------
rem | Usually you should set this to the data folder but if you saved the source from the CK to a mod set it to that source folder
rem | You can also set multiple paths here if you need to import mod source code
rem | seperate them with commas = ,
rem | Example: Skyrim Special Edition\Data\Source\Scripts
set import=

rem ----------------------------------------------------------------------------------------------------------------------------------
rem | Set this to the scripts folder you want to output to, recommended to not set this to the same as the base mod
rem | Example: OutputFolder\scripts
set output=


rem | extra argument data here https://falloutck.uesp.net/wiki/Papyrus_Compiler

cd /D %changedScripts%

for %%f in (.\*.psc) do (
	"%compiler%" "%%f" -f="%flg%" -i="%import%" -o="%output%"
)
