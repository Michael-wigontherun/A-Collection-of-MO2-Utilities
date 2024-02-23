using MO2CollectionGlobalLibrary;
using System.Text;

namespace DetectFrameworkAPI
{
    internal class Program
    {
        //                ScriptName, APIName
        static Dictionary<string    , string> DetectFrameworks = FrameworkList.BuildFrameworkListDictionary(FrameworkList.BuildFrameworkList());

        static List<ScriptReport> scriptReports = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, null);

            string path = GL._Settings.SetDefaultOutputPaths("Reports", "DetectFrameworkAPI.Report.txt");

            BuildScriptReport();

            OutputScriptReport(path);

            GL.Explorer(GL._Settings.OutputPath, path);

            GL.EndPause();
        }

        static void BuildScriptReport()
        {
            IEnumerable<string> pscs = Directory.EnumerateFiles(GL._Settings.Path, "*.psc");
            foreach (string psc in pscs)
            {
                ScriptReport scriptReport = new ScriptReport(Path.GetFileName(psc));
                string[] lines = File.ReadAllLines(psc);
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    foreach (var apiScript in DetectFrameworks)
                    {
                        if (line.Contains(apiScript.Key, StringComparison.OrdinalIgnoreCase))
                        {
                            scriptReport.AddAPI(apiScript.Value, apiScript.Key, i + 1);
                        }
                    }
                }
                scriptReports.Add(scriptReport);
            }
        }

        static void OutputScriptReport(string outputPath)
        {
            List<string> containsNoOutrightAPIRefereneces = new();
            using StreamWriter sw = new(outputPath, false);
            sw.WriteLine("These are the API references found inside " + GL._Settings.Path);
            sw.WriteLine("The hiarcy of this report is:");
            sw.WriteLine("1) Script name found in " + GL._Settings.Path);
            sw.WriteLine("\t2)  API Name");
            sw.WriteLine("\t\t3)  API Script found apart of the API");
            sw.WriteLine("\n\n\n\n");
            sw.WriteLine("------------------------------------------------------------------------------------------");
            foreach (var report in scriptReports)
            {
                if (report.APIOccurences == 0)
                {
                    containsNoOutrightAPIRefereneces.Add(report.ScriptName);
                    continue;
                }
                sw.WriteLine(report.ScriptName);

                foreach(var apiNames in report.lines.Keys)
                {
                    sw.WriteLine("\t" + apiNames);
                    foreach(var line in report.GetReportLines(apiNames))
                    {
                        sw.WriteLine("\t\t" + line);
                    }
                }

                sw.WriteLine("\n\n\n\n");
                sw.WriteLine("------------------------------------------------------------------------------------------");
            }

            if(containsNoOutrightAPIRefereneces.Count > 0)
            {
                sw.WriteLine("These scripts had no outright API references: ");
                foreach (string scriptName in containsNoOutrightAPIRefereneces)
                {
                    sw.WriteLine("\t" + scriptName);
                }
            }
        }
    }

    internal class ScriptReport
    {
        public string ScriptName = String.Empty;

        public int APIOccurences = 0;

        //                apiName,            ScriptName, lineNumbers
        public Dictionary<string , Dictionary<string    , List<int>>> lines { get; set; } = new();

        public ScriptReport(string scriptName)
        {
            ScriptName = scriptName;
        }

        private void AddAPI(string apiName)
        {
            if (!lines.ContainsKey(apiName)) lines.Add(apiName, new Dictionary<string, List<int>>());
        }

        private void AddAPI(string apiName, string ScriptName)
        {
            AddAPI(apiName);
            if (!lines[apiName].ContainsKey(ScriptName)) lines[apiName].Add(ScriptName, new List<int>());
        }

        public  void AddAPI(string apiName, string ScriptName, int line)
        {
            AddAPI(apiName, ScriptName);
            lines[apiName][ScriptName].Add(line);
            APIOccurences++;
        }

        public List<string> GetReportLines(string apiName)
        {
            List<string> reportLines = new List<string>();

            foreach(var lineList in lines[apiName])
            {
                reportLines.Add(lineList.Key + " : " + string.Join(" , ", lineList.Value));
            }



            return reportLines;
        }

    }


}