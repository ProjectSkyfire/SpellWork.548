namespace SpellWork.DBC.Structures
{
    public sealed class SpellCategoriesEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint unk0;                                         // 2  - Panadraia, difficulty?
        public uint Category;
        public uint DmgClass;
        public uint Dispel;
        public uint Mechanic;
        public uint PreventionType;
        public uint StartRecoveryCategory;
        public uint unk1;                                         // 9        Pandaria
    }
}
