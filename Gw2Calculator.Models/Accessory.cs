using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class Accessory : TrinketBase
    {
        protected override int TripleStatMajorAttributePoints => 110;
        protected override int TripleStatMinorAttributePoints => 74;
        protected override int QuadrupleStatMajorAttributePoints => 92;
        protected override int QuadrupleStatMinorAttributePoints => 49;
        protected override int CelestialAttributePoints => 57;

        public Accessory(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }
    }
}
