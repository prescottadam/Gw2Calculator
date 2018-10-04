using System;
using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public abstract class ArmorBase : ItemBase
    {
        protected abstract int AttributePoints { get; }

        public ArmorBase(IEnumerable<AttributeMultiplier> multipliers) : base(multipliers)
        {
        }

        protected override void CalculateAttributeValues(IEnumerable<AttributeMultiplier> multipliers)
        {
            foreach (var multiplier in multipliers)
            {
                var value = (int)Math.Round(AttributePoints * multiplier.Value, MidpointRounding.ToEven);
                SetAttributeValue(multiplier.AttributeName, value);
            }
        }
    }
}
