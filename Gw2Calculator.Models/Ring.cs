using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class Ring : TrinketBase
    {
        protected override int TripleStatMajorAttributePoints => 126;
        protected override int TripleStatMinorAttributePoints => 85;
        protected override int QuadrupleStatMajorAttributePoints => 106;
        protected override int QuadrupleStatMinorAttributePoints => 56;
        protected override int CelestialAttributePoints => 57;

        public Ring(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }
    }
}
