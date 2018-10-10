using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class BackItem : TrinketBase
    {
        protected override int TripleStatMajorAttributePoints => 63;
        protected override int TripleStatMinorAttributePoints => 40;
        protected override int QuadrupleStatMajorAttributePoints => 52;
        protected override int QuadrupleStatMinorAttributePoints => 27;
        protected override int CelestialAttributePoints => 28;

        public BackItem(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }
    }
}
