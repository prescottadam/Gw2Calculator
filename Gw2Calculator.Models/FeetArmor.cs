using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class FeetArmor : ArmorBase
    {
        protected override int AttributePoints => 135;

        public FeetArmor(IEnumerable<AttributeMultiplier> multipliers) : base(multipliers)
        {
        }
    }
}
