using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Gw2Calculator.Models
{
    public abstract class ItemBase
    {
        public int Power { get; set; }
        public int Precision { get; set; }
        public int Toughness { get; set; }
        public int Vitality { get; set; }
        public int Concentration { get; set; }
        public int ConditionDamage { get; set; }
        public int Expertise { get; set; }
        public int Ferocity { get; set; }
        public int HealingPower { get; set; }

        public ItemBase(IEnumerable<AttributeMultiplier> multipliers)
        {
            CalculateAttributeValues(multipliers);
        }

        protected abstract void CalculateAttributeValues(IEnumerable<AttributeMultiplier> multipliers);

        protected void SetAttributeValue(string attributeName, int value)
        {
            var property =
                GetType()
                    .GetProperty(attributeName)
                    .GetSetMethod();
            property.Invoke(this, new object[] { value });
        }
    }
}
