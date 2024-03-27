namespace MainMenuRandomizerAssistant
{
    using MO2CollectionGlobalLibrary;
    internal class Program
    {
        static Settings Settings => GL._Settings;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, null);

            var menufolders = Directory.EnumerateDirectories(Settings.Path).ToArray();

            string mainmenuwallpapersPath = Path.Combine(Settings.Path, "mainmenuwallpapers");
            Directory.CreateDirectory(mainmenuwallpapersPath);

            foreach (var menuFolder in menufolders)
            {
                var assetfolders = Directory.EnumerateDirectories(menuFolder).ToArray();
                if(assetfolders.Any())
                {
                    string DATAPath = Path.Combine(menuFolder, "DATA");
                    Directory.CreateDirectory(DATAPath);
                    foreach (var assetFolder in assetfolders)
                    {
                        Directory.Move(assetFolder, Path.Combine(DATAPath, Path.GetFileName(assetFolder)));
                    }
                    Directory.Move(menuFolder, Path.Combine(mainmenuwallpapersPath, Path.GetFileName(menuFolder)));
                }
            }

            GL.Explorer(GL._Settings.Path, "");
            GL.EndPause();
        }
    }
}
