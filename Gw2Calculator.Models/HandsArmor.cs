using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class HandsArmor : ItemBase
    {
        protected override int AttributePoints => 135;

        public HandsArmor(IEnumerable<AttributeMultiplier> attributeMultipliers) : base(attributeMultipliers)
        {
        }
    }
}
