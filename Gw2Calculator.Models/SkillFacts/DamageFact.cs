namespace Gw2Calculator.Models.SkillFacts
{
    public class DamageFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Damage;

        public int Hits { get; set; }
        public decimal Multiplier { get; set; }
    }
}
