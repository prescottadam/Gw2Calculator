using System.Collections.Generic;
using Gw2Calculator.Models.SkillFacts;

namespace Gw2Calculator.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public IEnumerable<ISkillFact> Facts { get; set; }
        public string Description { get; set; }
        public SkillTypeEnum Type { get; set; }
    }
}
