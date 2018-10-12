namespace Gw2Calculator.Models.SkillFacts
{
    public class BuffFact : SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Buff;

        public string Status { get; set; }
        public string Description { get; set; }
        public int? Counts { get; set; }
        public int? Duration { get; set; }
    }
}
