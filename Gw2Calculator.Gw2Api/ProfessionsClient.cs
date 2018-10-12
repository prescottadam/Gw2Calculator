using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gw2Calculator.Models;
using Gw2Calculator.Models.SkillFacts;
using Newtonsoft.Json.Linq;

namespace Gw2Calculator.Gw2Api
{
    public interface IProfessionsClient
    {
        Task<IEnumerable<string>> GetProfessionsAsync();

        Task<IEnumerable<Skill>> GetSkillsAsync(string professionName);
    }

    public class ProfessionsClient : ApiClientBase, IProfessionsClient
    {
        private readonly SkillFactFactory _skillFactFactory;

        public ProfessionsClient()
        {
            _skillFactFactory = new SkillFactFactory();
        }

        public async Task<IEnumerable<string>> GetProfessionsAsync()
        {
            var response = await GetAsync<JArray>(ApiEndpoints.Professions);
            var professions = response.Children();
            return response.Values<string>().ToArray();
        }

        public async Task<IEnumerable<Skill>> GetSkillsAsync(string professionName)
        {
            var getProfessionResponse = await GetAsync<JObject>(ApiEndpoints.Profession(professionName));
            var skillIds =
                getProfessionResponse["skills"]
                    .Children<JObject>()
                    .Select(x => x.Value<string>("id"))
                    .ToArray();

            var getSkillsResponse = await GetAsync<JArray>(ApiEndpoints.Skill(skillIds));
            var skills = 
                getSkillsResponse
                    .Children()
                    .Select(x => new Skill
                    {
                        Name = x.Value<string>("name"),
                        Facts = ParseSkillFacts(x.Value<JArray>("facts")),
                        Description = x.Value<string>("description"),
                        Type = Enum.Parse<SkillTypeEnum>(x.Value<string>("type"))
                    })
                    .ToArray();
            
            return skills;
        }

        private IEnumerable<ISkillFact> ParseSkillFacts(JArray facts)
        {
            return 
                facts?
                    .Children()
                    .Select(x => _skillFactFactory.CreateFact(x))
                    .ToArray();
        }
    }
}
