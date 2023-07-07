using MO2CollectionGlobalLibrary;

namespace DARPriorityReader
{
    internal class Program
    {
        public static Settings _Settings = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            args = new string[] { @"-P=E:\SkyrimMods\MO2\mods\Fancy Sword Moveset for MCO - Sword - 249999900" };

            try
            {
                _Settings = Settings.Args(args, false, false, null);
                if (!_Settings.Start)
                {
                    GL.WriteLine("Problem with Arguments.");
                    GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
                    Console.ReadLine();
                    return;
                }

                List<DARFolder> DARFolders = new();

                IEnumerable<string> _CustomConditionFolders = Directory.GetDirectories(Path.Combine(_Settings.Path, "Meshes"),
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


                Directory.CreateDirectory("DARMods");
                using (StreamWriter sw = new("DARMods\\DARPriorityReaderReport.txt", false))
                {
                    foreach (DARFolder dARFolder in DARFolders)
                    {
                        if (dARFolder.Priorities.Count > 0)
                        {
                            dARFolder.Priorities = dARFolder.Priorities.OrderBy(x => x).ToHashSet();
                            GL.WriteLine(dARFolder.FolderPath);
                            sw.WriteLine(dARFolder.FolderPath);
                            foreach(int i in dARFolder.Priorities)
                            {
                                GL.WriteLine(i.ToString());
                                sw.WriteLine(i.ToString());
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }


            Console.WriteLine("Press Enter to end...");
            Console.ReadLine();
        }
    }
}