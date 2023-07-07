using MO2CollectionGlobalLibrary;

namespace DARPriorityReader
{
    internal class Program
    {
        public static Settings _Settings = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            _Settings = Settings.Args(args, false, false, null);
            if (!_Settings.Start)
            {
                GL.WriteLine("Problem with Arguments.");
                GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
                Console.ReadLine();
                return;
            }

            List<DARFolder> DARFolders = new();

            IEnumerable<string> _CustomConditionFolders = Directory.GetDirectories(Path.Combine(args[0], "Meshes"),
                    "DynamicAnimationReplacer",
                    SearchOption.AllDirectories);
            foreach (string _CustomConditionFolder in _CustomConditionFolders)
            {
                DARFolder dARFolder = new DARFolder(_CustomConditionFolder);
                IEnumerable<string> priorityFolders = Directory.GetDirectories(_CustomConditionFolder,
                    "*",
                    SearchOption.TopDirectoryOnly);
                foreach (string priorityFolder in priorityFolders)
                {
                    if (int.TryParse(Path.GetFileName(_CustomConditionFolder), out int value)) dARFolder.Priorities.Add(value);
                }
                DARFolders.Add(dARFolder);
            }

            using (StreamWriter sw = new("DARMods\\DARPriorityReaderReport.txt", false))
            {
                foreach (DARFolder dARFolder in DARFolders)
                {
                    if(dARFolder.Priorities.Count > 0)
                    {
                        dARFolder.Priorities = dARFolder.Priorities.OrderBy(x => x).ToHashSet();
                        sw.WriteLine(dARFolder.FolderPath);
                        foreach(int i in dARFolder.Priorities)
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
            



            Console.WriteLine("Press Enter to end...");
            Console.ReadLine();
        }
    }
}