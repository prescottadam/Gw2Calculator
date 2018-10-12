namespace Gw2Calculator.Models.SkillFacts
{
    public class ComboFinisherFact : SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.ComboFinisher;

        public ComboFinisherTypeEnum FinisherType { get; set; }
        public int Percent { get; set; }
    }
}
