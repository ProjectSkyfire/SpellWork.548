using DBFilesClient.NET;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellMiscEntry
    {
        public uint Id = 0;                                           // 0        m_ID
        public uint SpellId = 0;                                      // 1
        public uint Unk = 0;                                          // 2
        public uint Attributes = 0;                                   // 3        m_attribute
        public uint AttributesEx = 0;                                 // 4        m_attributesEx
        public uint AttributesEx2 = 0;                                // 5        m_attributesExB
        public uint AttributesEx3 = 0;                                // 6        m_attributesExC
        public uint AttributesEx4 = 0;                                // 7        m_attributesExD
        public uint AttributesEx5 = 0;                                // 8        m_attributesExE
        public uint AttributesEx6 = 0;                                // 9       m_attributesExF
        public uint AttributesEx7 = 0;                                // 10       m_attributesExG
        public uint AttributesEx8 = 0;                                // 11       m_attributesExH
        public uint AttributesEx9 = 0;                                // 12       m_attributesExI
        public uint AttributesEx10 = 0;                               // 13       m_attributesExJ
        public uint AttributesEx11 = 0;                               // 14       m_attributesExK
        public uint AttributesEx12 = 0;                               // 15       m_attributesExL
        public uint AttributesEx13 = 0;                               // 16       m_attributesExL
        public uint CastingTimeIndex = 0;                             // 17       m_castingTimeIndex
        public uint DurationIndex = 0;                                // 18       m_durationIndex
        public uint RangeIndex = 0;                                   // 19       m_rangeIndex
        public float Speed = 0;                                        // 20       m_speed
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] SpellVisual;                                  // 21-22    m_spellVisualID
        public uint SpellIconID = 0;                                  // 23       m_spellIconID
        public uint ActiveIconID = 0;                                 // 24       m_activeIconID
        public uint SchoolMask = 0;                                   // 25       m_schoolMask
    }
}
