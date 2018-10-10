using System.Collections.Generic;
using System.Linq;

namespace Gw2Calculator.Models
{
    public abstract class TrinketBase : ItemBase
    {
        protected abstract int TripleStatMajorAttributePoints { get; }
        protected abstract int TripleStatMinorAttributePoints { get; }
        protected abstract int QuadrupleStatMajorAttributePoints { get; }
        protected abstract int QuadrupleStatMinorAttributePoints { get; }
        protected abstract int CelestialAttributePoints { get; }

        public TrinketBase(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }

        protected override void CalculateAttributeValues(IEnumerable<ItemStatAttribute> attributes)
        {
            var attributeCount = attributes.Count();
            if (attributeCount == 3)
            {
                foreach (var attribute in attributes.OrderByDescending(x => x.Multiplier).Take(1))
                {
                    SetAttributeValue(attribute.Name, TripleStatMajorAttributePoints);
                }
                foreach (var attribute in attributes.OrderBy(x => x.Multiplier).Take(2))
                {
                    SetAttributeValue(attribute.Name, TripleStatMinorAttributePoints);
                }
            }
            else if (attributeCount == 4)
            {
                foreach (var attribute in attributes.OrderByDescending(x => x.Multiplier).Take(2))
                {
                    SetAttributeValue(attribute.Name, QuadrupleStatMajorAttributePoints);
                }
                foreach (var attribute in attributes.OrderBy(x => x.Multiplier).Take(2))
                {
                    SetAttributeValue(attribute.Name, QuadrupleStatMinorAttributePoints);
                }
            }
            else if (attributeCount == 7)
            {
                foreach (var attribute in attributes)
                {
                    SetAttributeValue(attribute.Name, CelestialAttributePoints);
                }
            }
        }
    }
}
