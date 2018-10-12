namespace Gw2Calculator.Models.SkillFacts
{
    public class RechargeFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Recharge;

        public int Value { get; set; }
    }
}
