namespace SpellWork.DBC.Structures
{
    public sealed class SpellLevelsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint Difficulty;                                   // 2  - Pandaria
        public uint BaseLevel;
        public uint MaxLevel;
        public uint SpellLevel;
    }
}
