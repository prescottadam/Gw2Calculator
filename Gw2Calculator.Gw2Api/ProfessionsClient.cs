using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gw2Calculator.Models;
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
        public ProfessionsClient()
        {
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
                        //Facts = x.Value<JArray>("facts"),
                        Description = x.Value<string>("description"),
                        Type = Enum.Parse<SkillTypeEnum>(x.Value<string>("type"))
                    })
                    .Where(x => x.Type != SkillTypeEnum.Profession)
                    .ToArray();
            
            return skills;
        }
    }
}
