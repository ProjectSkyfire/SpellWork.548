using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellEffectScalingEntry
    {
        public uint Id;                                                // 1       Id
        public float Multiplier;                                       // 2
        public float RandomPointsMultiplier;                           // 3
        public float OtherMultiplier;                                  // 4
        public float UnkMultiplier;                                    // 5
        public uint SpellEffectId;                                     // 6
    }
}
