static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
    GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, null);

    string path = GL._Settings.SetDefaultOutputPaths("DefaultOutputPath", "DefaultOutputName");









    GL.Explorer(GL._Settings.OutputPath, path);
    GL.EndPause();
}