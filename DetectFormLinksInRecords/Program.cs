using MO2CollectionGlobalLibrary;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Noggog;

namespace DetectFormLinksInRecords
{
    internal class Program
    {
        static Settings Settings => GL._Settings;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string extraString = "Add plugin names here to only report on specific links or records. Can be list." +
                "\nYou can also omit this arg and it will report on every link and rec." +
                "\nExample: -S=\"doublejump.esp\"." +
                "\nExample: -S=\"doublejump.esp, Inigo.esp\".";
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, false, extraString);

            string path = GL._Settings.SetDefaultOutputPaths("Reports", $"{System.IO.Path.GetFileNameWithoutExtension(GL._Settings.Path)}.FormLinks.yaml");

            var mod = SkyrimMod.CreateFromBinaryOverlay(Settings.Path, SkyrimRelease.SkyrimSE);

            Dictionary<string, HashSet<string>> overrideRecs = new();
            Dictionary<string, HashSet<string>> containsLinks = new();

            if (Settings.ExtraString.Equals(String.Empty))
            {
                foreach (IMajorRecordGetter rec in mod.EnumerateMajorRecords())
                {
                    if (!overrideRecs.ContainsKey(rec.FormKey.ModKey.ToString().ToLower())) overrideRecs.Add(rec.FormKey.ModKey.ToString().ToLower(), new());
                    overrideRecs[rec.FormKey.ModKey.ToString().ToLower()].Add(rec.FormKey.ToString());

                    foreach (var link in rec.EnumerateFormLinks())
                    {
                        if (!containsLinks.ContainsKey(link.FormKey.ModKey.ToString().ToLower())) containsLinks.Add(link.FormKey.ModKey.ToString().ToLower(), new());
                        containsLinks[link.FormKey.ModKey.ToString().ToLower()].Add(rec.FormKey.ToString());
                    }
                }
            }
            else
            {
                HashSet<ModKey> modKeys = new();
                foreach (string modkey in Settings.ExtraString.Split(','))
                {
                    modKeys.Add(ModKey.FromFileName(modkey));
                }

                foreach (IMajorRecordGetter rec in mod.EnumerateMajorRecords())
                {
                    if (modKeys.Contains(rec.FormKey.ModKey))
                    {
                        if (!overrideRecs.ContainsKey(rec.FormKey.ModKey.ToString().ToLower())) overrideRecs.Add(rec.FormKey.ModKey.ToString().ToLower(), new());
                        overrideRecs[rec.FormKey.ModKey.ToString().ToLower()].Add(rec.FormKey.ToString());

                        continue;
                    }
                    foreach (var link in rec.EnumerateFormLinks())
                    {
                        if (modKeys.Contains(link.FormKey.ModKey))
                        {
                            if (!containsLinks.ContainsKey(link.FormKey.ModKey.ToString().ToLower())) containsLinks.Add(link.FormKey.ModKey.ToString().ToLower(), new());
                            containsLinks[link.FormKey.ModKey.ToString().ToLower()].Add(rec.FormKey.ToString());
                        }
                    }
                }
            }


            #region Output
            string pluginName = Path.GetFileName(Settings.Path);
            HashSet<string> ignoredPlugins = new HashSet<string>()
            {
                "Skyrim.esm",
                "Dawnguard.esm",
                "HearthFires.esm",
                "Dragonborn.esm",
                pluginName
            };

            var stream = File.AppendText(path);
            string outputS = "# These records are directly overwriten by " + pluginName;
            Console.WriteLine(outputS);
            stream.WriteLine(outputS);
            Console.WriteLine("OverrideRecs:");
            stream.WriteLine("OverrideRecs:");
            foreach (var overrideRec in overrideRecs)
            {
                if (ignoredPlugins.Contains(overrideRec.Key, StringComparer.OrdinalIgnoreCase)) continue;

                Console.WriteLine("\t - " + overrideRec.Key + ":");
                stream.WriteLine("\t - " + overrideRec.Key.Replace(":", ";") + ":");
                foreach(string s in overrideRec.Value)
                {
                    Console.WriteLine("\t\t - " + s);
                    stream.WriteLine("\t\t - " + s.Replace(":", ";"));
                }
            }

            outputS = "# These records have links in records in " + pluginName;
            Console.WriteLine(outputS);
            stream.WriteLine(outputS);
            Console.WriteLine("ContainsLinks:");
            stream.WriteLine("ContainsLinks:");
            foreach (var containsLink in containsLinks)
            {
                if (ignoredPlugins.Contains(containsLink.Key, StringComparer.OrdinalIgnoreCase)) continue;

                Console.WriteLine("\t - " + containsLink.Key + ":");
                stream.WriteLine("\t - " + containsLink.Key.Replace(":", ";") + ":");
                foreach (string s in containsLink.Value)
                {
                    Console.WriteLine("\t\t - " + s);
                    stream.WriteLine("\t\t - " + s.Replace(":", ";"));
                }
            }

            stream.Close();
            stream.Dispose();
            #endregion Output


            GL.Explorer(GL._Settings.OutputPath, path);
            GL.EndPause();
        }
    }
}