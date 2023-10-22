using MO2CollectionGlobalLibrary;

namespace DARPriorityReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, "Add -S=\"MO2\"\nDARPriorityReader look at the folder as MO2's mods folder and it will search and output paths using MO2 mods.");
            if (!GL._Settings.Start)
            {
                GL.WriteLine("Problem with Arguments.");
                GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
                Console.ReadLine();
                return;
            }
            
            try
            {
                List<DARFolder> DARFolders;
                if (GL._Settings.ExtraString.Equals("MO2", StringComparison.OrdinalIgnoreCase))
                {
                    DARFolders = DARMO2ModsFolder();
                }
                else
                {
                    DARFolders = DARDataFolder(GL._Settings.Path);
                }

                string outputPath = "DARMods";
                string outputName = "DARPriorityReaderReport.txt";

                if (!GL._Settings.OutputPath.Equals(String.Empty))
                {
                    outputPath = GL._Settings.OutputPath;
                }

                if (!GL._Settings.OutputName.Equals(String.Empty))
                {
                    outputName = GL._Settings.OutputName;
                }

                Directory.CreateDirectory(outputPath);
                string outputFilePath = Path.Combine(outputPath, outputName);

                using (StreamWriter sw = new (outputFilePath, false))
                {
                    foreach (DARFolder dARFolder in DARFolders)
                    {
                        if (dARFolder.Priorities.Count > 0)
                        {
                            dARFolder.Priorities = dARFolder.Priorities.OrderBy(x => x).ToHashSet();
                            GL.WriteLine(dARFolder.FolderPath);
                            sw.WriteLine(dARFolder.FolderPath);
                            foreach (int i in dARFolder.Priorities)
                            {
                                GL.WriteLine(i.ToString());
                                sw.WriteLine(i.ToString());
                            }
                        }
                    }
                }//end output

                GL.WriteLine("Output to: " + Path.GetFullPath(outputFilePath));

                GL.Explorer(outputPath, outputFilePath);
                GL.EndPause();
            }//end try
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Press Enter to end...");
                Console.ReadLine();
            }


            
        }

        private static List<DARFolder> DARMO2ModsFolder()
        {
            List<DARFolder> DARFolders = new();

            IEnumerable<string> modFolders = Directory.GetDirectories(GL._Settings.Path,
                        "*",
                        SearchOption.TopDirectoryOnly);
            foreach (string modFolder in modFolders)
            {
                if (modFolder.Contains("_backup", StringComparison.OrdinalIgnoreCase)) continue;
                if (modFolder.Contains("_separator", StringComparison.OrdinalIgnoreCase)) continue;

                string meshesfolder = Path.Combine(modFolder, "Meshes");
                
                if (!Directory.Exists(meshesfolder)) continue;

                DARFolder dARFolder = new DARFolder(modFolder);
                IEnumerable<string> _CustomConditionFolders = Directory.GetDirectories(meshesfolder,
                        "_CustomConditions",
                        SearchOption.AllDirectories);
                foreach (string _CustomConditionFolder in _CustomConditionFolders)
                {
                    IEnumerable<string> priorityFolders = Directory.GetDirectories(_CustomConditionFolder,
                        "*",
                        SearchOption.TopDirectoryOnly);
                    foreach (string priorityFolder in priorityFolders)
                    {
                        if (int.TryParse(Path.GetFileName(priorityFolder), out int value))
                        {
                            dARFolder.Priorities.Add(value);
                        }
                    }//End _CustomConditions priority Iteration
                    DARFolders.Add(dARFolder);
                }//End MO2 mod _CustomConditions Folder iteration
            }//End MO2 mods folder iteration

            return DARFolders;
        }

        private static List<DARFolder> DARDataFolder(string path)
        {
            List<DARFolder> DARFolders = new();

            IEnumerable<string> _CustomConditionFolders = Directory.GetDirectories(Path.Combine(path, "Meshes"),
                        "_CustomConditions",
                        SearchOption.AllDirectories);
            foreach (string _CustomConditionFolder in _CustomConditionFolders)
            {
                DARFolder dARFolder = new DARFolder(_CustomConditionFolder);
                IEnumerable<string> priorityFolders = Directory.GetDirectories(_CustomConditionFolder,
                    "*",
                    SearchOption.TopDirectoryOnly);
                foreach (string priorityFolder in priorityFolders)
                {
                    if (int.TryParse(Path.GetFileName(priorityFolder), out int value))
                    {
                        dARFolder.Priorities.Add(value);
                    }
                }
                DARFolders.Add(dARFolder);
            }

            return DARFolders;
        }
    }
}