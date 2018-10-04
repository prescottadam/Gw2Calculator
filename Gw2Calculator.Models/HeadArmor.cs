using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class HeadArmor : ItemBase
    {
        protected override int AttributePoints => 180;

        public HeadArmor(IEnumerable<AttributeMultiplier> attributeMultipliers) : base(attributeMultipliers)
        {
        }
    }
}
