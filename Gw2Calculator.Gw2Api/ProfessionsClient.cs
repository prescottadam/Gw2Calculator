using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gw2Calculator.Gw2Api.Models;

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

        public Task<IEnumerable<string>> GetProfessionsAsync()
        {
            return GetAsync<IEnumerable<string>>(ApiEndpoints.Professions);
        }

        public async Task<IEnumerable<SkillReference>> GetSkillsAsync(string professionName)
        {
            var profession = await GetAsync<Profession>(ApiEndpoints.Profession(professionName));
            return profession.Skills.ToList();
        }
    }
}
