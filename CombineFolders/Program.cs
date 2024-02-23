using MO2CollectionGlobalLibrary;

namespace CombineFolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string ExtraString = "Folder name to search for to copy from. Can be in list form." +
                "\nExample: Meshes" +
                "\nExample: Meshes,Textures, SKSE, dlc01chalice.nif" +
                "\nWill copy each folder name into the output frolder.";
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, true, ExtraString);

            string path = GL._Settings.SetDefaultOutputPaths(GL._Settings.Path, null, false);

            var folderNames = GL._Settings.ExtraString.Split(',', StringSplitOptions.TrimEntries);

            foreach ( var folderName in folderNames )
            {
                IEnumerable<string> folderPaths = Directory.GetDirectories(GL._Settings.Path, folderName, SearchOption.AllDirectories);
                foreach ( var folderPath in folderPaths )
                {
                    if (Directory.Exists(folderPath))
                    {
                        GL.CopyDirectory(folderPath, Path.Combine(GL._Settings.OutputPath, folderName), true);
                    }
                    if (File.Exists(folderPath))
                    {
                        File.Copy(folderPath, Path.Combine(GL._Settings.OutputPath, Path.GetFileName(folderPath)));
                    }
                }
            }

            GL.EndPause();
        }

        
    }
}
