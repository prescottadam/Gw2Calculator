namespace Gw2Calculator.Models.SkillFacts
{
    public class DistanceFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Distance;

        public int Distance { get; set; }
    }
}
