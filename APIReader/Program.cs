using MO2CollectionGlobalLibrary;

namespace APIReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, true, false, null);

            if (!GL._Settings.Start)
            {
                GL.WriteLine("Problem with Arguments.");
                GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
                Console.ReadLine();
                return;
            }

            Directory.CreateDirectory("FrameworkLists");
            IEnumerable<string> scripts = Directory.EnumerateFiles(GL._Settings.Path, "*.pex", SearchOption.AllDirectories);
            IEnumerable<string> scourceScripts = Directory.EnumerateFiles(GL._Settings.Path, "*.psc", SearchOption.AllDirectories);
            HashSet<string> allScripts = new HashSet<string>();
            foreach(string script in scripts)
            {
                allScripts.Add(Path.GetFileNameWithoutExtension(script));
            }
            foreach (string script in scourceScripts)
            {
                allScripts.Add(Path.GetFileNameWithoutExtension(script));
            }

            File.WriteAllLines($"FrameworkLists\\{GL._Settings.OutputName}", allScripts.ToArray());

            GL.Explorer("FrameworkLists", $"FrameworkLists\\{GL._Settings.OutputName}");
            GL.EndPause();
        }
    }
}