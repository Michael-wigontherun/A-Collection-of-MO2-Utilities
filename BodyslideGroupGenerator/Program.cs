using MO2CollectionGlobalLibrary;
using System.Diagnostics;

namespace BodyslideGroupGenerator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                GL.WriteLine("Hello, World!");
                string ExtraString = "Enter the name of the base bodyslide group. Can be a list." +
                    "\nYou can locate this by looking at another slidergroup XML." +
                    "\nExample: -S=\"CBBE\" is the group name for CBBE based bodies." +
                    "\nExample: -s=\"CBBE, Common Clothes and Armors\"";
                GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, true, true, true, ExtraString);
                
                List<string> objectNames = new();

                if (Directory.Exists(GL._Settings.Path))
                {
                    IEnumerable<string> files = Directory.GetFiles(GL._Settings.Path, "*.osp", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        objectNames.AddRange(SingleFile(file));
                    }
                }
                else if (File.Exists(GL._Settings.Path))
                {
                    objectNames.AddRange(SingleFile(GL._Settings.Path));
                }
                else
                {
                    GL.WriteLine("Path not found.");
                    Console.ReadLine();
                }

                if (objectNames.Any())
                {
                    var groupNames = GL._Settings.ExtraString.Split(',', StringSplitOptions.TrimEntries);

                    string outputFilePath = Path.Combine(GL._Settings.OutputPath, GL._Settings.OutputName + ".xml");

                    using (StreamWriter sw = new(outputFilePath, false))
                    {
                        sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF - 8\"?>");
                        sw.WriteLine("<SliderGroups>");
                        sw.WriteLine($"\t<Group name=\"{GL._Settings.OutputName}\">");
                        foreach (string objectName in objectNames)
                        {
                            sw.WriteLine($"\t\t<Member name=\"{objectName}\"/>");
                        }
                        sw.WriteLine("\t</Group>");

                        foreach (string groupName in groupNames)
                        {
                            sw.WriteLine($"\t<Group name=\"{groupName}\">");
                            foreach (string objectName in objectNames)
                            {
                                sw.WriteLine($"\t\t<Member name=\"{objectName}\"/>");
                            }
                            sw.WriteLine("\t</Group>");
                        }


                        sw.WriteLine("</SliderGroups>");
                    }

                    GL.WriteLine(GL._Settings.OutputName + ".xml saved.");

                    GL.Explorer(GL._Settings.OutputPath, outputFilePath);

                    
                }
                else
                {
                    GL.WriteLine("No Slider Sets to generate. Safe to ignore unless another error is pressent.");
                }

                GL.EndPause();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
        }

        

        public static List<string> SingleFile(string ospPath)
        {
            List<string> objectNames = new();

            Console.WriteLine();
            GL.WriteLine(ospPath);
            Console.WriteLine();
            SliderSetInfo? osp = SliderSetInfo.GetOSP(ospPath);
            if (osp != null)
            {
                if (osp.SliderSet != null)
                {
                    foreach (var set in osp.SliderSet)
                    {
                        if (set.Name != null)
                        {
                            objectNames.Add(set.Name);
                        }
                        else GL.WriteLine("sliderset name not loaded");
                    }
                }
                else GL.WriteLine($"{ospPath} slidersets not loaded");
            }
            else GL.WriteLine($"{ospPath} not loaded");

            return objectNames;
        }
    }

    
}