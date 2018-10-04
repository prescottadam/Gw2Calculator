using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gw2Calculator.Gw2Api.Models;

namespace Gw2Calculator.Gw2Api
{
    public interface IItemStatsClient
    {
        Task<IEnumerable<ItemStat>> GetItemStatsAsync();
    }

    public class ItemStatsClient : ApiClientBase, IItemStatsClient
    {
        public async Task<IEnumerable<ItemStat>> GetItemStatsAsync()
        {
            var itemStatIds = await GetAsync<List<string>>(ApiEndpoints.ItemStats);
            var allItemStats = await GetAsync<IEnumerable<ItemStat>>(ApiEndpoints.ItemsStats(itemStatIds));
            return allItemStats.Where(x => x.Attributes?.Length >= 3).ToArray();
        }
    }
}
