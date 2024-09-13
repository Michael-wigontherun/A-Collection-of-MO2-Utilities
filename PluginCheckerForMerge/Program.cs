using MO2CollectionGlobalLibrary;
using Mutagen.Bethesda.Skyrim;
using Noggog;

namespace PluginCheckerForMerge
{
    internal class Program
    {
        static Settings Settings => GL._Settings;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, World!");
                string extraString = "This is the max number of New Forms that you are comfortable with merging." +
                                   "\nDefault is 10. As I dont like merging plugins with more then 10 new records";
                GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, extraString);

                int MaxNewForms;
                if (Settings.ExtraString.Equals(String.Empty)) MaxNewForms = 10;
                else if (!int.TryParse(Settings.ExtraString, out MaxNewForms))
                {
                    Console.WriteLine("Extra String not an int, must be a number");
                    Console.WriteLine("Press Enter to continue or close the program...");
                    Console.ReadLine();
                    MaxNewForms = 10;
                }

                HashSet<string> ignoreplugins = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                if (File.Exists("IgnorePlugins.txt"))
                {
                    ignoreplugins.Add<string>(File.ReadAllLines("IgnorePlugins.txt"));
                }

                string outputPath = GL._Settings.SetDefaultOutputPaths("Reports", "ValidPluginsForMerge.txt");
                string[] pluginsFileName = File.ReadAllLines(Settings.Path);

                List<string> plugins = new List<string>();

                foreach (string pluginLine in pluginsFileName)
                {
                    if (!pluginLine.StartsWith('*')) continue;

                    string pluginName = pluginLine.Remove(0, 1);

                    Console.WriteLine("Checking: " + pluginName);
                    if (ignoreplugins.Contains(pluginName)) continue;

                    string filepath = Path.Combine(GL._JSON.DataFolderPath, pluginName);
                    if (!File.Exists(filepath)) continue;

                    if (filepath.EndsWith(".esm", StringComparison.OrdinalIgnoreCase)) continue;//ESM file

                    try
                    {
                        SkyrimMod mod = SkyrimMod.CreateFromBinary(filepath, SkyrimRelease.SkyrimSE);

                        if (mod.NavigationMeshInfoMaps.Count > 0) continue;//No Navigation Mesh info Maps
                        if (mod.ModHeader.Flags.HasFlag(SkyrimModHeader.HeaderFlag.Master)) continue;//ESP-M

                        int newRecCount = 0;
                        foreach (var rec in mod.EnumerateMajorRecords())
                        {
                            if (rec.FormKey.ModKey.Equals(mod.ModKey)) newRecCount++;
                        }

                        if (newRecCount > MaxNewForms) continue;//More then 10

                        plugins.Add(pluginName);
                    }catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                        Console.WriteLine(e.Message);
                    }
                }

                File.WriteAllLines(outputPath, plugins.ToArray());




                GL.Explorer(GL._Settings.OutputPath, outputPath);
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            GL.EndPause();
        }

    }
}

//No Navigation Mesh info Maps
//Less than 10 new forms
//Not a ESM or ESP-M
