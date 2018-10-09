using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gw2Calculator.Gw2Api.Models;
using Newtonsoft.Json.Linq;

namespace Gw2Calculator.Gw2Api
{
    public interface IProfessionsClient
    {
        Task<IEnumerable<string>> GetProfessionsAsync();

        Task<IEnumerable<SkillReference>> GetSkillsAsync(string professionName);
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

        public async Task<IEnumerable<SkillReference>> GetSkillsAsync(string professionName)
        {
            var response = await GetAsync<JObject>(ApiEndpoints.Profession(professionName));
            var skills = response["skills"];
            return 
                skills
                    .Children<JObject>()
                    .Select(x => new SkillReference
                    {
                        Id = x.Value<string>("id"),
                        Slot = x.Value<string>("slot"),
                        Type = x.Value<string>("type")
                    })
                    .ToArray();
        }
    }
}
