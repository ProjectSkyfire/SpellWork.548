using DBFilesClient.NET;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellScalingEntry
    {
        public uint Id;
        public int MinCastTime;
        public int MaxCastTime;
        public uint MaxCastTimeLevel;   // player level at which cast time reaches max value
        public int PlayerClass;
        public float CoefBase;
        public uint CoefLevelBase;
        public uint Unk1; // Pandaria
        public uint Unk2; // Pandaria
    }
}
