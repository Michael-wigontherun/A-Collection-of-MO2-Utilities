using MO2CollectionGlobalLibrary;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;

namespace ScriptEditor
{
    internal class Program
    {
        static Settings Settings => GL._Settings;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, null);

            if(!File.Exists(Settings.Path))
            {
                Console.WriteLine("Json path does not exist.");
                GL.EndPause();
                return;
            }
            Configuration con;
            try
            {
                con = JsonSerializer.Deserialize<Configuration>(File.ReadAllText(Settings.Path))!;
                if (!con.HasValidNode())
                {
                    Console.WriteLine("Configuarion not valid.");
                    GL.EndPause();
                    return;
                }
                con.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                GL.EndPause();
                return;
            }

            List<string> sourceFiles = Directory.EnumerateFiles(con.ModPath, "*.psc", SearchOption.AllDirectories).ToList();
            
            foreach (var sourceFile in sourceFiles)
            {
                Console.WriteLine(sourceFile);
                var lines = File.ReadAllLines(sourceFile).ToList();

                bool editted = false;

                foreach(var node in con.ConfigurationNodes)
                {
                    if (!node.IsValid()) continue;
                    List<int> lineNums = new();
                    //find lines
                    for (int i = 0; i < lines.Count; i++) if (lines[i].Contains(node.SearchString, StringComparison.OrdinalIgnoreCase)) lineNums.Insert(0, i);

                    //configure changes
                    for (int i = 0; i < lineNums.Count; i++)
                    {
                        for (int j = 0; j < node.DuplicateLine; j++)
                        {
                            lines.Insert(lineNums[i] + 1, lines[lineNums[i]] + " ; Duplicated Line");// + " -------- " + (lineNums[i] + 1)
                            editted = true;
                        }

                        if (node.ReplaceSearch != null)
                        {
                            lines[lineNums[i]] = lines[lineNums[i]].Replace(node.SearchString, node.ReplaceSearch) + " ; Replaced search string";
                            editted = true;
                        }

                        if (node.ReplaceLine != null)
                        {
                            lines[lineNums[i]] = node.ReplaceLine + " ; Replaced search line";
                            editted = true;
                        }

                        if (node.Lines != null)
                        {
                            int lineNum = lineNums[i];
                            if (!node.LinesInsertAbove)
                            {
                                lineNum += node.DuplicateLine;
                                lineNum++;
                            }

                            lines.InsertRange(lineNum, node.Lines);
                            editted = true;
                        }
                    }

                }

                //foreach (var line in lines) Console.WriteLine(line);

                if (editted)
                {
                    if (con.OutputLocation == null) File.WriteAllLines(sourceFile, lines);
                    else
                    {
                        File.WriteAllLines(Path.Combine(con.OutputLocation, Path.GetFileName(sourceFile)), lines);
                    }
                }
                
            }
            
            


            GL.EndPause();
        }
    }
}
