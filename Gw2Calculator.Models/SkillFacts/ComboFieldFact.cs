namespace Gw2Calculator.Models.SkillFacts
{
    public class ComboFieldFact: SkillFactBase
    {
        public override SkillFactTypeEnum Type => SkillFactTypeEnum.ComboField;

        public ComboFieldTypeEnum FieldType { get; set; }
    }
}
