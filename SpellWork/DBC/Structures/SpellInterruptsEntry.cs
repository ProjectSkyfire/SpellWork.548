namespace SpellWork.DBC.Structures
{
    public sealed class SpellInterruptsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint Difficulty;                                   // 2  - Panadraia
        public uint AuraInterruptFlags;
        public uint Unknown1;
        public uint ChannelInterruptFlags;
        public uint Unknown2;
        public uint InterruptFlags;
    }
}
