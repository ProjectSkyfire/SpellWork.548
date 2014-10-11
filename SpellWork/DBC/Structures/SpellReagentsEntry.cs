using DBFilesClient.NET;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellReagentsEntry
    {
        public uint Id;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 9)]
        public uint[] ItemId;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 9)]
        public uint[] Count;
    }
}
