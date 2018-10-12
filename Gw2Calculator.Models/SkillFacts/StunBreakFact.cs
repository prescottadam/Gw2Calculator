namespace Gw2Calculator.Models.SkillFacts
{
    public class StunBreakFact : SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.StunBreak;

        public bool Value { get; set; }
    }
}
