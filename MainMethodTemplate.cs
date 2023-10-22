static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
    GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, null);

    if (!GL._Settings.Start)
    {
        GL.WriteLine("Problem with Arguments.");
        GL.WriteLine("Run with the Argument \"-Help\" without quotes for help.");
        Console.ReadLine();
        return;
    }
    string path = GL._Settings.SetDefaultOutputPaths("DefaultOutputPath", "DefaultOutputName");









    GL.Explorer(GL._Settings.OutputPath, path);
    GL.EndPause();
}