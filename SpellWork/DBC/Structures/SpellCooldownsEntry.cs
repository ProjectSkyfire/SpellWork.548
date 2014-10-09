namespace SpellWork.DBC.Structures
{
    public sealed class SpellCooldownsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint unk0;                                         // 2  - Panadraia, difficulty?
        public uint CategoryRecoveryTime;
        public uint RecoveryTime;
        public uint StartRecoveryTime;
    }
}
