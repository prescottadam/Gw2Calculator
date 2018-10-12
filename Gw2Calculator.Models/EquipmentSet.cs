using System;
using System.Linq;

namespace Gw2Calculator.Models
{
    public class EquipmentSet
    {
        public int Power { get => SumAttribute(x => x.Power); }
        public int Precision { get => SumAttribute(x => x.Precision); }
        public int Toughness { get => SumAttribute(x => x.Toughness); }
        public int Vitality { get => SumAttribute(x => x.Vitality); }
        public int Concentration { get => SumAttribute(x => x.Concentration); }
        public int ConditionDamage { get => SumAttribute(x => x.ConditionDamage); }
        public int Expertise { get => SumAttribute(x => x.Expertise); }
        public int Ferocity { get => SumAttribute(x => x.Ferocity); }
        public int HealingPower { get => SumAttribute(x => x.HealingPower); }

        public HeadArmor HeadSlot { get; set; }
        public ShoulderArmor ShoulderSlot { get; set; }
        public ChestArmor ChestSlot { get; set; }
        public HandArmor HandSlot { get; set; }
        public LegArmor LegSlot { get; set; }
        public FeetArmor FeetSlot { get; set; }
        public BackItem BackSlot { get; set; }
        public Accessory AccessorySlot1 { get; set; }
        public Accessory AccessorySlot2 { get; set; }
        public Amulet AmuletSlot { get; set; }
        public Ring RingSlot1 { get; set; }
        public Ring RingSlot2 { get; set; }

        private ItemBase[] AllSlots
        {
            get
            {
                return new ItemBase[]
                {
                    HeadSlot,
                    ShoulderSlot,
                    ChestSlot,
                    HandSlot,
                    LegSlot,
                    FeetSlot,
                    BackSlot,
                    AccessorySlot1,
                    AccessorySlot2,
                    AmuletSlot,
                    RingSlot1,
                    RingSlot2
                };
            }
        }


        private int SumAttribute(Func<ItemBase, int> attribute)
        {
            return AllSlots.Where(x => x != null).Sum(attribute);
        }
    }
}
