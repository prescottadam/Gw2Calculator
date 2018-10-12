namespace Gw2Calculator.Models.SkillFacts
{
    public class TimeFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Time;

        public int Duration { get; set; }
    }
}
