namespace SpellWork.DBC.Structures
{
    public sealed class SpellPowerEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint Difficulty;                                   // 2  - Pandaria
        public uint PowerType;
        public uint ManaCost;
        public uint ManaCostPerlevel;
        public uint ManaPerSecond;
        public uint ManaPerSecondPerLevel;
        public uint PowerDisplayId;
        public float ManaCostPercentage;
        public float UnkMop1; // Pandaria
        public uint RequiredAura; // Pandaria
        public float UnkMop2; // Pandaria
    }
}
