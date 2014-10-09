namespace SpellWork.DBC.Structures
{
    public sealed class SpellPowerEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint unk0;                                         // 2  - Panadraia, difficulty?
        public uint PowerType;
        public uint ManaCost;
        public uint ManaCostPerlevel;
        public uint ManaPerSecond;
        public uint ManaPerSecondPerLevel;
        public uint PowerDisplayId;
        public float ManaCostPercentage;
        public float Unknown1; // Pandaria
        public float RequiredAura; // Pandaria
        public float Unknown2; // Pandaria
    }
}
