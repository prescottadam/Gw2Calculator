using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class ChestArmor : ItemBase
    {
        protected override int AttributePoints => 404;

        public ChestArmor(IEnumerable<AttributeMultiplier> attributeMultipliers) : base(attributeMultipliers)
        {
        }
    }
}
