using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class ShoulderArmor : ArmorBase
    {
        protected override int AttributePoints => 135;

        public ShoulderArmor(IEnumerable<AttributeMultiplier> multipliers) : base(multipliers)
        {
        }
    }
}
