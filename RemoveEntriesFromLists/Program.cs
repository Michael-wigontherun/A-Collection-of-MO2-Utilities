using MO2CollectionGlobalLibrary;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;

namespace RemoveEntriesFromLists
{
    internal class Program
    {
        static HashSet<string> plugins = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string ExtraString = "Add the plugin names to remove from level lists and containers" +
                "Example: -S=\"aMidianBorn_ContentAddon.esp, OWL_AMB_CA_Patch.esp\"";
            GL._Settings = Settings.Args(typeof(Program).Namespace!.ToString(), args, false, false, true, ExtraString);

            plugins = GL._Settings.ExtraString.Split(',', StringSplitOptions.TrimEntries).ToHashSet();

            try
            {
                Mod();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            GL.EndPause();
        }

        private static void Mod()
        {
            
            var mod = SkyrimMod.CreateFromBinary(GL._Settings.Path, SkyrimRelease.SkyrimSE);
            
            foreach (var key in mod.LeveledItems.FormKeys)
            {
                if (mod.LeveledItems[key].Entries == null) continue;

                foreach(var entry in mod.LeveledItems[key].Entries!.ToArray())
                {
                    if (entry.Data == null) continue;
                    if (!plugins.Contains(entry.Data.Reference.FormKey.ModKey.ToString(), StringComparer.OrdinalIgnoreCase)) continue;

                    mod.LeveledItems[key].Entries!.Remove(entry);
                }
            }
            
            foreach (var key in mod.Containers.FormKeys)
            {
                if (mod.Containers[key].Items == null) continue;

                foreach (var entry in mod.Containers[key].Items!.ToArray())
                {
                    if (entry.Item.Item == null) continue;
                    if (!plugins.Contains(entry.Item.Item.FormKey.ModKey.ToString(), StringComparer.OrdinalIgnoreCase)) continue;

                    mod.Containers[key].Items!.Remove(entry);
                }
            }

            foreach(var key in mod.FormLists.FormKeys)
            {
                if (mod.FormLists[key].Items == null)continue;
                foreach(var entry in mod.FormLists[key].Items!.ToArray())
                {
                    if (!plugins.Contains(entry.FormKey.ModKey.ToString(), StringComparer.OrdinalIgnoreCase)) continue;

                    mod.FormLists[key]!.Items!.Remove(entry);
                }
            }

            foreach(var rec in mod.EnumerateMajorRecords())
            {
                rec.IsCompressed = false;
            }


            mod.WriteToBinary(GL._Settings.Path,
                new Mutagen.Bethesda.Plugins.Binary.Parameters.BinaryWriteParameters()
                {
                    MastersListOrdering =
                    new Mutagen.Bethesda.Plugins.Binary.Parameters.MastersListOrderingByLoadOrder(
                        Mutagen.Bethesda.Plugins.Order.LoadOrder.GetLoadOrderListings(GameRelease.SkyrimSE,
                        new Noggog.DirectoryPath("DataFolderPath")).ToLoadOrder())
                });
        }
    }
}