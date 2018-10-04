using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class LegsArmor : ItemBase
    {
        protected override int AttributePoints => 269;

        public LegsArmor(IEnumerable<AttributeMultiplier> attributeMultipliers) : base(attributeMultipliers)
        {
        }
    }
}
