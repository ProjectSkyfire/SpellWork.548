namespace SpellWork.DBC.Structures
{
    public sealed class SpellEquippedItemsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint Difficulty;                                   // 2  - Panadraia
        public uint EquippedItemClass;
        public uint EquippedItemInventoryTypeMask;
        public uint EquippedItemSubClassMask;
    }
}
