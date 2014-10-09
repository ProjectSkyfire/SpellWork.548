namespace SpellWork.DBC.Structures
{
    public sealed class SpellInterruptsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint unk0;                                         // 2  - Panadraia, difficulty?
        public uint AuraInterruptFlags;
        public uint Unknown1;
        public uint ChannelInterruptFlags;
        public uint Unknown2;
        public uint InterruptFlags;
    }
}
