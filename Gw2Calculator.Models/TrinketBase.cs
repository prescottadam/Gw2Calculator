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

        public TrinketBase(IEnumerable<AttributeMultiplier> multipliers) : base(multipliers)
        {
        }

        protected override void CalculateAttributeValues(IEnumerable<AttributeMultiplier> multipliers)
        {
            var attributeCount = multipliers.Count();
            if (attributeCount == 3)
            {
                foreach (var multiplier in multipliers.OrderByDescending(x => x.Value).Take(1))
                {
                    SetAttributeValue(multiplier.AttributeName, TripleStatMajorAttributePoints);
                }
                foreach (var multiplier in multipliers.OrderBy(x => x.Value).Take(2))
                {
                    SetAttributeValue(multiplier.AttributeName, TripleStatMinorAttributePoints);
                }
            }
            else if (attributeCount == 4)
            {
                foreach (var multiplier in multipliers.OrderByDescending(x => x.Value).Take(2))
                {
                    SetAttributeValue(multiplier.AttributeName, QuadrupleStatMajorAttributePoints);
                }
                foreach (var multiplier in multipliers.OrderBy(x => x.Value).Take(2))
                {
                    SetAttributeValue(multiplier.AttributeName, QuadrupleStatMinorAttributePoints);
                }
            }
            else if (attributeCount == 7)
            {
                foreach (var multiplier in multipliers)
                {
                    SetAttributeValue(multiplier.AttributeName, CelestialAttributePoints);
                }
            }
        }
    }
}
