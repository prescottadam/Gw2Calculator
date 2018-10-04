using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Gw2Calculator.Models
{
    public abstract class ItemBase
    {
        protected abstract int AttributePoints { get; }

        public int Power { get; set; }
        public int Precision { get; set; }
        public int Toughness { get; set; }
        public int Vitality { get; set; }
        public int Concentration { get; set; }
        public int ConditionDamage { get; set; }
        public int Expertise { get; set; }
        public int Ferocity { get; set; }
        public int HealingPower { get; set; }

        public ItemBase(IEnumerable<AttributeMultiplier> attributeMultipliers)
        {
            foreach (var attributeMultiplier in attributeMultipliers)
            {
                var property = 
                    GetType()
                        .GetProperty(attributeMultiplier.Attribute)
                        .GetSetMethod();

                var value = (int)Math.Round(AttributePoints * attributeMultiplier.Value, MidpointRounding.ToEven);
                property.Invoke(this, new object[] { value });
            }
        }
    }
}
