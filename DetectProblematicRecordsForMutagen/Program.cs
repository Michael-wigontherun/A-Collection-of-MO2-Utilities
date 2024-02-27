using MO2CollectionGlobalLibrary;
using Mutagen.Bethesda.Skyrim;

namespace DetectProblematicRecordsForMutagen
{
    internal partial class Program
    {
        static Settings Settings => GL._Settings;
        static string Path = "";
        static StreamWriter? stream;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, null);

            Path = GL._Settings.SetDefaultOutputPaths("Reports", $"{System.IO.Path.GetFileNameWithoutExtension(GL._Settings.Path)}.MutegenError.txt");
            stream = File.AppendText(Path);

            try
            {
                var mod = SkyrimMod.CreateFromBinaryOverlay(Settings.Path, SkyrimRelease.SkyrimSE);
                try
                {
                    EnumerateMajorRecords(mod);
                }catch (Exception ex)
                {
                    WriteLine("SomeThing unexpected happened.");
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }catch (Exception ex)
            {
                WriteLine("Mod Failed to load.");
                WriteLine(ex.Message);
                WriteLine(ex.StackTrace!);
                WriteLine("\n\n\n");
            }

            stream!.Close();
            stream!.Dispose();
            GL.Explorer(GL._Settings.OutputPath, Path);
            GL.EndPause();
        }

        static void WriteLine(string line)
        {
            Console.WriteLine(line);
            stream!.WriteLine(line);
        }

        static void EnumerateMajorRecords(ISkyrimModDisposableGetter mod)
        {
            try
            {
                foreach (var rec in mod.EnumerateMajorRecords()) { }
                WriteLine("No problematic records. Synthesis should have no problems with this plugin.");
            }
            catch (Exception ex)
            {
                WriteLine("One or more records are a problem for mutegen.");
                WriteLine(ex.Message);
                WriteLine(ex.StackTrace!);
                WriteLine("\n\n\n");
                WriteLine("Checking Individual Records.");
                IndividualBasic(mod);
            }
        }

        

    }
}