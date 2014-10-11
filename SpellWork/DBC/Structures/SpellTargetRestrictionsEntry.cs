namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint Difficulty;                                   // 2  - Pandaria
        public float Unk1;
        public uint UnkMop1; // Mop
        public uint MaxAffectedTargets;
        public uint MaxTargetLevel;
        public uint TargetCreatureType;
        public uint Targets;
    }
}
