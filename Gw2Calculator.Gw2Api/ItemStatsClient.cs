using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gw2Calculator.Models;
using Newtonsoft.Json.Linq;

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
            var response = await GetAsync<JArray>(ApiEndpoints.ItemStats);
            var itemStatIds = response.Children().Values<string>();
            
            response = await GetAsync<JArray>(ApiEndpoints.ItemsStats(itemStatIds));
            var allItemStats = 
                response
                    .Children()
                    .Select(x => new ItemStat
                    {
                        Id = x.Value<string>("id"),
                        Name = x.Value<string>("name"),
                        Attributes = 
                            x.Value<JArray>("attributes")
                                .Children()
                                .Select(attr => new ItemStatAttribute
                                {
                                    Name = x.Value<string>("attribute"),
                                    Multiplier = x.Value<decimal>("multiplier"),
                                    Value = x.Value<int>("value")
                                })
                                .ToArray()
                    })
                    .ToArray();

            return allItemStats.Where(x => x.Attributes?.Length >= 3).ToArray();
        }
    }
}
