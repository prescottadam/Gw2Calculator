namespace Gw2Calculator.Models.SkillFacts
{
    public class PrefixedBuffFact : BuffFact
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.PrefixedBuff;

        public BuffFact Prefix { get; set; }
    }
}
