namespace Gw2Calculator.Models.SkillFacts
{
    public class AttributeAdjustFact : SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.AttributeAdjust;

        public int Value { get; set; }
        public string Target { get; set; }
    }
}
