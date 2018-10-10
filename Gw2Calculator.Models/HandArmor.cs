using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class HandArmor : ArmorBase
    {
        protected override int AttributePoints => 135;

        public HandArmor(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }
    }
}
