namespace Gw2Calculator.Models
{
    public class AttributeMultiplier
    {
        public string AttributeName;
        public decimal Value;

        public AttributeMultiplier(string attributeName, decimal value)
        {
            AttributeName = attributeName;
            Value = value;
        }
    }
}
