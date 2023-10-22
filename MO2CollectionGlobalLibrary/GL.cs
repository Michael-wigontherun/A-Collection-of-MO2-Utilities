﻿using System.Diagnostics;

namespace MO2CollectionGlobalLibrary
{
    public static class GL
    {
        public static Settings _Settings = new();

        public static void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public static void Explorer(string? outputFolder, string? outputFilePath)
        {
            if (_Settings.Explorer && outputFolder != null)
            {
                Process.Start("explorer.exe", "\"" + Path.GetFullPath(outputFolder) + "\"");
            }

            if (!_Settings.DefaultProgramName.Equals(String.Empty) && outputFilePath != null)
            {
                Process.Start(_Settings.DefaultProgramName, "\"" + Path.GetFullPath(outputFilePath) + "\"");
            }
        }

        public static void EndPause()
        {
            if (!_Settings.NoPause)
            {
                Console.WriteLine("Press Enter to end...");
                Console.ReadLine();
            }
        }
    }

    public class Settings
    {
        public static Settings Args(string logName, string[] args, bool outputFolder, bool outputName, bool requiresExtra, string? ExtraName, bool pathRequired = true)
        {
            Settings settings = new();
            settings.LogName = logName + ".txt";
            void PrintHelp()
            {
                string seperator = "-------------------------------------------------------------------------------------------";
                Console.WriteLine(seperator);
                Console.WriteLine("-P=\"Path intended object\"");
                Console.WriteLine();
                Console.WriteLine("BodyslideGroupGenerator.exe this can be a .osp file or a folder containing .osp files.");
                Console.WriteLine();
                Console.WriteLine("Required: " + pathRequired);
                Console.WriteLine(seperator);
                Console.WriteLine("-O=\"Output Folder Path\"");
                Console.WriteLine();
                Console.WriteLine("This is the output folder path to output files.");
                Console.WriteLine();
                Console.WriteLine("Required: " + outputFolder);
                Console.WriteLine(seperator);
                Console.WriteLine("-N=\"Name of output file\"");
                Console.WriteLine();
                Console.WriteLine("This will be the name of the file outputted without extension.");
                Console.WriteLine();
                Console.WriteLine("Required: " + outputName);
                Console.WriteLine(seperator);
                Console.WriteLine("-E=\"Name of default program\"");
                Console.WriteLine();
                Console.WriteLine("This will open the single or multiple files with the default program of your choice.");
                Console.WriteLine();
                Console.WriteLine("This is not required for any program.");
                Console.WriteLine(seperator);
                Console.WriteLine("-E");
                Console.WriteLine();
                Console.WriteLine("This will open the output folder in the File Browser.");
                Console.WriteLine();
                Console.WriteLine("This is not required for any program.");
                Console.WriteLine(seperator);
                if (ExtraName != null)
                {
                    Console.WriteLine("-S=\"Extra Data\"");
                    Console.WriteLine();
                    Console.WriteLine(ExtraName);
                    Console.WriteLine();
                    Console.WriteLine("Required: " + requiresExtra);
                    Console.WriteLine(seperator);
                }
                Console.WriteLine("-NP");
                Console.WriteLine();
                Console.WriteLine("This will disable the pause at the end of the program.");
                Console.WriteLine();
                Console.WriteLine("This is not required for any program.");
                Console.WriteLine(seperator);

                settings.Start = false;
                return;
            }

            foreach (string arg in args)
            {
                if (arg.Equals("-Help"))
                {
                    PrintHelp();
                    settings.Start = false;
                    break;
                }
                else if (arg.Contains("-P=", StringComparison.OrdinalIgnoreCase))
                {
                    settings.Path = arg.Replace("-P=", "", StringComparison.OrdinalIgnoreCase);
                }
                else if (arg.Contains("-O=", StringComparison.OrdinalIgnoreCase))
                {
                    settings.OutputPath = arg.Replace("-O=", "", StringComparison.OrdinalIgnoreCase);
                }
                else if (arg.Contains("-N=", StringComparison.OrdinalIgnoreCase))
                {
                    settings.OutputName = arg.Replace("-N=", "", StringComparison.OrdinalIgnoreCase);
                }
                else if (arg.Contains("-S=", StringComparison.OrdinalIgnoreCase))
                {
                    settings.ExtraString = arg.Replace("-S=", "", StringComparison.OrdinalIgnoreCase);
                }
                else if (arg.Contains("-E=", StringComparison.OrdinalIgnoreCase))
                {
                    settings.DefaultProgramName = arg.Replace("-E=", "", StringComparison.OrdinalIgnoreCase);
                }
                else if (arg.Equals("-E", StringComparison.OrdinalIgnoreCase))
                {
                    settings.Explorer = true;
                }
                else if (arg.Equals("-NP", StringComparison.OrdinalIgnoreCase))
                {
                    settings.NoPause = true;
                }
            }

            if (args.Length == 0) PrintHelp();

            if (pathRequired && settings.Path.Equals(String.Empty)) settings.Start = false;
            if (outputFolder && settings.OutputPath.Equals(String.Empty)) settings.Start = false;
            if (outputName && settings.OutputName.Equals(String.Empty)) settings.Start = false;
            if (requiresExtra && settings.ExtraString.Equals(String.Empty)) settings.Start = false;

            return settings;
        }
        
        public bool Start { get; private set; } = true;

        public string Path { get; set; } = String.Empty;

        public string OutputPath { get; set; } = String.Empty;

        public string OutputName { get; set; } = String.Empty;

        public string DefaultProgramName { get; set; } = String.Empty;

        public string ExtraString { get; set; } = String.Empty;

        public bool Explorer { get; set; } = false;

        public bool NoPause { get; set; } = false;

        public string LogName = String.Empty;

        public string SetDefaultOutputPaths(string outputPath, string outputName)
        {
            if (OutputPath.Equals(String.Empty))
            {
                OutputPath = outputPath;
            }
            if (OutputName.Equals(String.Empty))
            {
                OutputName = outputName;
            }

            Directory.CreateDirectory(OutputPath);
            File.Create(OutputName).Close();

            return GetOutputPath();
        }

        public string GetOutputPath()
        {
            return System.IO.Path.Combine(OutputPath, OutputName);
        }
    }
}