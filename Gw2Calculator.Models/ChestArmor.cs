using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class ChestArmor : ArmorBase
    {
        protected override int AttributePoints => 404;

        public ChestArmor(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }
    }
}
