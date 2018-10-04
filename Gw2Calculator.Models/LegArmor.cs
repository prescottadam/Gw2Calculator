using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class LegArmor : ArmorBase
    {
        protected override int AttributePoints => 269;

        public LegArmor(IEnumerable<AttributeMultiplier> multipliers) : base(multipliers)
        {
        }
    }
}
