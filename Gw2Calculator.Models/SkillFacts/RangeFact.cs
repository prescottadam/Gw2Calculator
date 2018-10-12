namespace Gw2Calculator.Models.SkillFacts
{
    public class RangeFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Range;

        public int Value { get; set; }
    }
}
