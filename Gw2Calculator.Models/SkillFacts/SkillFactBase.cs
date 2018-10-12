namespace Gw2Calculator.Models.SkillFacts
{
    public interface ISkillFact
    {
        string Text { get; set; }
        string Icon { get; set; }
        SkillFactTypeEnum Type { get; }
    }

    public abstract class SkillFactBase : ISkillFact
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public abstract SkillFactTypeEnum Type { get; }
    }
}
