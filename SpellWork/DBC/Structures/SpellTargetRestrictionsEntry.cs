namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        public uint Id;
        public uint SpellId;                                      // 1  - Pandaria
        public uint Unk0;                                         // 2  - Panadraia, difficulty?
        public float Unk1;
        public uint Unk2;
        public uint MaxAffectedTargets;
        public uint MaxTargetLevel;
        public uint TargetCreatureType;
        public uint Targets;
    }
}
