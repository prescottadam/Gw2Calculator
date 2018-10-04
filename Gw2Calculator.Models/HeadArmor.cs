using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class HeadArmor : ArmorBase
    {
        protected override int AttributePoints => 180;

        public HeadArmor(IEnumerable<AttributeMultiplier> multipliers) : base(multipliers)
        {
        }
    }
}
