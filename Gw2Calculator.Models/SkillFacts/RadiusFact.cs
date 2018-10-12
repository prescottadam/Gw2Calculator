namespace Gw2Calculator.Models.SkillFacts
{
    public class RadiusFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.Radius;

        public int Distance { get; set; }
    }
}
