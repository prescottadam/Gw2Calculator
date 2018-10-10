namespace Gw2Calculator.Models
{
    public class ItemStatAttribute
    {
        public string Name { get; set; }
        public decimal Multiplier { get; set; }
        public int Value { private get; set; } // private getter until we know what it's for

        public ItemStatAttribute()
        {
        }

        public ItemStatAttribute(string name, decimal multiplier)
        {
            Name = name;
            Multiplier = multiplier;
        }
    }
}
