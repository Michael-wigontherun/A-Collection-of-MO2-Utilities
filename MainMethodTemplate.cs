using MO2CollectionGlobalLibrary;
internal class Program
{
    static Settings Settings => GL._Settings;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, null);

        string path = GL._Settings.SetDefaultOutputPaths("Reports", "DefaultOutputName");









        GL.Explorer(GL._Settings.OutputPath, path);
        GL.EndPause();
    }
}