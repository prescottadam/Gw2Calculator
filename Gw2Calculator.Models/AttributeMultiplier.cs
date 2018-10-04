namespace Gw2Calculator.Models
{
    public class AttributeMultiplier
    {
        public string Attribute;
        public decimal Value;

        public AttributeMultiplier(string attribute, decimal multiplier)
        {
            Attribute = attribute;
            Value = multiplier;
        }
    }
}
