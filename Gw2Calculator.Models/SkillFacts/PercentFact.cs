namespace Gw2Calculator.Models.SkillFacts
{
    public class PercentFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Percent;

        public int Percent { get; set; }
    }
}
