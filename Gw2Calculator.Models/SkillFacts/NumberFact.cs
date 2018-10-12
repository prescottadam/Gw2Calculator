namespace Gw2Calculator.Models.SkillFacts
{
    public class NumberFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Number;

        public int? Value { get; set; }
        public int? Percent { get; set; }
    }
}
