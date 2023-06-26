using MO2CollectionGlobalLibrary;
using System.Diagnostics;

namespace BodyslideGroupGenerator
{
    internal class Program
    {
        public static Settings _Settings = new();

        public static void Main(string[] args)
        {
            try
            {
                GL.WriteLine("Hello, World!");

                _Settings = Settings.Args(args, true, true, ExtraName: "Enter the name of the base bodyslide group.\nYou can locate this by looking at another slidergroup XML.\nExample: -S=\"CBBE\" is the group name for CBBE based bodies.");
                 
                if (!_Settings.Start)
                {
                    GL.WriteLine("Problem with Arguments.");
                    GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
                    Console.ReadLine();
                    return;
                }

                List<string> objectNames = new();

                if (Directory.Exists(_Settings.Path))
                {
                    IEnumerable<string> files = Directory.GetFiles(_Settings.Path, "*.osp", SearchOption.TopDirectoryOnly);
                    foreach (string file in files)
                    {
                        objectNames.AddRange(SingleFile(file));
                    }
                }
                else if (File.Exists(_Settings.Path))
                {
                    objectNames.AddRange(SingleFile(_Settings.Path));
                }
                else
                {
                    GL.WriteLine("Path not found.");
                    Console.ReadLine();
                }

                if (objectNames.Any())
                {
                    string outputFilePath = Path.Combine(_Settings.OutputPath, _Settings.OutputName + ".xml");

                    using (StreamWriter sw = new(outputFilePath, false))
                    {
                        sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF - 8\"?>");
                        sw.WriteLine("<SliderGroups>");
                        sw.WriteLine("\t<Group name=\"CBBE\">");
                        foreach (string objectName in objectNames)
                        {
                            sw.WriteLine($"\t\t<Member name=\"{objectName}\"/>");
                        }
                        sw.WriteLine("\t</Group>");
                        sw.WriteLine($"\t<Group name=\"{_Settings.OutputName}\">");
                        foreach (string objectName in objectNames)
                        {
                            sw.WriteLine($"\t\t<Member name=\"{objectName}\"/>");
                        }
                        sw.WriteLine("\t</Group>");
                        sw.WriteLine("</SliderGroups>");
                    }

                    GL.WriteLine(_Settings.OutputName + ".xml saved.");

                    if (_Settings.Explorer)
                    {
                        Process.Start("explorer.exe", _Settings.OutputPath);
                    }
                    if(_Settings.DefaultProgramName != null)
                    {
                        Process.Start(_Settings.DefaultProgramName, "\"" + outputFilePath + "\"");
                    }

                    
                }
                else
                {
                    GL.WriteLine("No Slider Sets to generate. Safe to ignore unless another error is pressent.");
                }


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