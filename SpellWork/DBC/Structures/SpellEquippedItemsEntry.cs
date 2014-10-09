namespace SpellWork.DBC.Structures
{
    public sealed class SpellEquippedItemsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint unk0;                                         // 2  - Panadraia, difficulty?
        public uint EquippedItemClass;
        public uint EquippedItemInventoryTypeMask;
        public uint EquippedItemSubClassMask;
    }
}
