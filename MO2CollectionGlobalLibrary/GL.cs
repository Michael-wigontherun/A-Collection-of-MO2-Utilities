namespace MO2CollectionGlobalLibrary
{
    public static class GL
    {
        public static void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        
    }

    public class Settings
    {
        public bool Start { get; private set; } = true;

        public string Path { get; set; } = String.Empty;

        public string OutputPath { get; set; } = String.Empty;

        public string OutputName { get; set; } = String.Empty;

        public string? DefaultProgramName { get; set; } = String.Empty;

        public string ExtraString { get; set; } = String.Empty;

        public bool Explorer { get; set; } = false;

        public static Settings Args(string[] args, bool outputFolder, bool outputName, string? ExtraName)
        {
            Settings settings = new();

            void PrintHelp()
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("-P=\"Path intended object\"");
                Console.WriteLine();
                Console.WriteLine("BodyslideGroupGenerator.exe this can be a .osp file or a folder containing .osp files.");
                Console.WriteLine();
                Console.WriteLine("This is required for all programs.");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("-O=\"Output Folder Path\"");
                Console.WriteLine();
                Console.WriteLine("This is the output folder path to output files.");
                Console.WriteLine();
                Console.WriteLine("Required: " + outputFolder);
                Console.WriteLine("If not required then this does nothing.");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("-N=\"Name of output file\"");
                Console.WriteLine();
                Console.WriteLine("This will be the name of the file outputted without extension.");
                Console.WriteLine();
                Console.WriteLine("Required: " + outputName);
                Console.WriteLine("If not required then this does nothing.");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("-E=\"Name of default program\"");
                Console.WriteLine();
                Console.WriteLine("This will open the single or multiple files with the default program of your choice.");
                Console.WriteLine();
                Console.WriteLine("This is not required for any program.");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("-E");
                Console.WriteLine();
                Console.WriteLine("This will open the output folder in the File Browser.");
                Console.WriteLine();
                Console.WriteLine("This is not required for any program.");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                if (ExtraName != null)
                {
                    Console.WriteLine("-S=\"Extra Data\"");
                    Console.WriteLine();
                    Console.WriteLine(ExtraName);
                    Console.WriteLine();
                    Console.WriteLine("Required: True");
                    Console.WriteLine("-------------------------------------------------------------------------------------------");
                }

                settings.Start = false;
                return;
            }

            foreach (string arg in args)
            {
                if (arg.Equals("-Help"))
                {
                    PrintHelp();
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
            }

            if(args.Length == 0) PrintHelp();

            if(settings.Path == null) settings.Start = false;
            if(outputFolder && settings.OutputPath.Equals(String.Empty)) settings.Start = false;
            if(outputName && settings.OutputName.Equals(String.Empty)) settings.Start = false;
            if(ExtraName != null && settings.ExtraString.Equals(String.Empty)) settings.Start = false;

            return settings;
        }


    }
}