using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class FeetArmor : ItemBase
    {
        protected override int AttributePoints => 135;

        public FeetArmor(IEnumerable<AttributeMultiplier> attributeMultipliers) : base(attributeMultipliers)
        {
        }
    }
}
