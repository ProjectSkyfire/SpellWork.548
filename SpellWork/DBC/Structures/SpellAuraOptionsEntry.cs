namespace SpellWork.DBC.Structures
{
    public sealed class SpellAuraOptionsEntry
    {
        public uint Id;
        public uint spellId;                                      // 1  - Pandaria
        public uint Difficulty;                                   // 2  - Pandaria, difficulty?
        public uint StackAmount;
        public uint ProcChance;
        public uint ProcCharges;
        public uint ProcFlags;
        public uint unk1;                                         // 7 - Pandaria
        public uint unk2;                                         // 8 - Pandaria
    }
}
