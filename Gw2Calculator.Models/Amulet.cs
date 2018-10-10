using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class Amulet : TrinketBase
    {
        protected override int TripleStatMajorAttributePoints => 157;
        protected override int TripleStatMinorAttributePoints => 108;
        protected override int QuadrupleStatMajorAttributePoints => 133;
        protected override int QuadrupleStatMinorAttributePoints => 71;
        protected override int CelestialAttributePoints => 72;

        public Amulet(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }
    }
}
