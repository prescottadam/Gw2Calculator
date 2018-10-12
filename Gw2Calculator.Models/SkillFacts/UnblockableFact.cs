namespace Gw2Calculator.Models.SkillFacts
{
    public class UnblockableFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Unblockable;

        public bool Value { get; set; }
    }
}
