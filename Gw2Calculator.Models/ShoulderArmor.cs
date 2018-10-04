using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class ShoulderArmor : ItemBase
    {
        protected override int AttributePoints => 135;

        public ShoulderArmor(IEnumerable<AttributeMultiplier> attributeMultipliers) : base(attributeMultipliers)
        {
        }
    }
}
