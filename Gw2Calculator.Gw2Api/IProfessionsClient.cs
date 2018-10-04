using System.Collections.Generic;
using System.Threading.Tasks;
using Gw2Calculator.Gw2Api.Models;

namespace Gw2Calculator.Gw2Api
{
    public interface IProfessionsClient
    {
        Task<IEnumerable<string>> GetProfessionsAsync();

        Task<IEnumerable<Skill>> GetSkillsAsync(string professionName);
    }
}
