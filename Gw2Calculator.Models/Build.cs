using System.Collections.Generic;

namespace Gw2Calculator.Models
{
    public class Build
    {
        private readonly int _basePower = 1000;
        private readonly int _basePrecision = 1000;
        private readonly int _baseToughness = 1000;
        private readonly int _baseVitality = 1000;

        public int Power { get => _basePower + Equipment.Power; }
        public int Precision { get => _basePrecision + Equipment.Precision; }
        public int Toughness { get => _baseToughness + Equipment.Toughness; }
        public int Vitality { get => _baseVitality + Equipment.Vitality; }
        public int Concentration { get => Equipment.Concentration; }
        public int ConditionDamage { get => Equipment.ConditionDamage; }
        public int Expertise { get => Equipment.Expertise; }
        public int Ferocity { get => Equipment.Ferocity; }
        public int HealingPower { get => Equipment.HealingPower; }

        public EquipmentSet Equipment { get; set; }

        private List<Skill> _skills;
        public List<Skill> Skills
        {
            get
            {
                return CalculateSkills();
            }
            set
            {
                _skills = value;
            }
        }

        private List<Skill> CalculateSkills()
        {
            return _skills;
        }
    }
}
