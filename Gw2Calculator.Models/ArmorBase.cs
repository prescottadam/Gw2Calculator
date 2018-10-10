using System;
using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public abstract class ArmorBase : ItemBase
    {
        protected abstract int AttributePoints { get; }

        public ArmorBase(IEnumerable<ItemStatAttribute> attributes) : base(attributes)
        {
        }

        protected override void CalculateAttributeValues(IEnumerable<ItemStatAttribute> attributes)
        {
            foreach (var attribute in attributes)
            {
                var value = (int)Math.Round(AttributePoints * attribute.Multiplier, MidpointRounding.ToEven);
                SetAttributeValue(attribute.Name, value);
            }
        }
    }
}
