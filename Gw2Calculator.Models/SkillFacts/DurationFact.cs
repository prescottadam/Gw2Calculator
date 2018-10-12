namespace Gw2Calculator.Models.SkillFacts
{
    public class DurationFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Duration;

        public int Duration { get; set; }
    }
}
