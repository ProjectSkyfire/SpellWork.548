namespace SpellWork.DBC.Structures
{
    public sealed class SpellLevelsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint unk0;                                         // 2  - Panadraia, difficulty?
        public uint BaseLevel;
        public uint MaxLevel;
        public uint SpellLevel;
    }
}
