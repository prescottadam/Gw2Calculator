namespace Gw2Calculator.Models.SkillFacts
{
    public class HealingAdjustFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.HealingAdjust;

        public int Hits { get; set; }
    }
}
