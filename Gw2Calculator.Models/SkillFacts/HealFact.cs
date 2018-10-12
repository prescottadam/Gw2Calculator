namespace Gw2Calculator.Models.SkillFacts
{
    public class HealFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Heal;

        public int Hits { get; set; }
    }
}
