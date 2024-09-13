using MO2CollectionGlobalLibrary;
using Mutagen.Bethesda;

namespace MutagenHelper
{
    public static class MutagenHelper
    {
        public static Mutagen.Bethesda.Plugins.Binary.Parameters.BinaryWriteParameters GetPluginOrder()
        {
            return new Mutagen.Bethesda.Plugins.Binary.Parameters.BinaryWriteParameters()
            {
                MastersListOrdering =
                    new Mutagen.Bethesda.Plugins.Binary.Parameters.MastersListOrderingByLoadOrder(
                        Mutagen.Bethesda.Plugins.Order.LoadOrder.GetLoadOrderListings(GameRelease.SkyrimSE,
                        new Noggog.DirectoryPath(GL._JSON.DataFolderPath)).ToLoadOrder())
            };
        }
    }
}
