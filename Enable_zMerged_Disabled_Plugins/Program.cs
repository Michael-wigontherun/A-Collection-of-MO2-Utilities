using MO2CollectionGlobalLibrary;
using System.Text.Json;

namespace Enable_zMerged_Disabled_Plugins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string extraS = "Path to the Plugins.txt file inside a MO2 Profile or the one in your Local AppData";
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, extraS);
            if (!GL._Settings.Start)
            {
                GL.WriteLine("Problem with Arguments.");
                GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
                Console.ReadLine();
                return;
            }
            if(!File.Exists(GL._Settings.Path) || !GL._Settings.Path.Contains(".json", StringComparison.OrdinalIgnoreCase))
            {
                GL.WriteLine("Merge.json not found.");
                GL.EndPause();
                return;
            }
            if (!File.Exists(GL._Settings.ExtraString))
            {
                GL.WriteLine("plugins.txt not found.");
                GL.EndPause();
                return;
            }

            var JSONFile = JsonSerializer.Deserialize<MergeJSON>(File.ReadAllText(GL._Settings.Path))!.ToHashSet();
            string[] pluginsTXT = File.ReadAllLines(GL._Settings.ExtraString);

            BackUpTXT(pluginsTXT);

            for(int i = 0; i < pluginsTXT.Length; i++)
            {
                //GL.WriteLine(pluginsTXT[i]);
                if (JSONFile.Contains(pluginsTXT[i], StringComparer.OrdinalIgnoreCase))
                {
                    GL.WriteLine("Enabling " + pluginsTXT[i]);
                    pluginsTXT[i] = "*" + pluginsTXT[i];
                }
            }

            File.WriteAllLines(GL._Settings.ExtraString, pluginsTXT);


            GL.EndPause();
        }

        static void BackUpTXT(string[] pluginsTXT)
        {
            string pluginsTXTBackup = Path.GetDirectoryName(GL._Settings.ExtraString) + "\\plugins.txt." + DateTime.Now.ToString("yyyy_M_d_H_m_s");
            File.WriteAllLines(pluginsTXTBackup, pluginsTXT);
        }
    }

    
}