using System;
using System.Linq;

namespace Gw2Calculator.Models
{
    public class EquipmentSet
    {
        public int Power { get { return SumAttribute(x => x.Power); } }
        public int Precision { get { return SumAttribute(x => x.Precision); } }
        public int Toughness { get { return SumAttribute(x => x.Toughness); } }
        public int Vitality { get { return SumAttribute(x => x.Vitality); } }
        public int Concentration { get { return SumAttribute(x => x.Concentration); } }
        public int ConditionDamage { get { return SumAttribute(x => x.ConditionDamage); } }
        public int Expertise { get { return SumAttribute(x => x.Expertise); } }
        public int Ferocity { get { return SumAttribute(x => x.Ferocity); } }
        public int HealingPower { get { return SumAttribute(x => x.HealingPower); } }

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
