using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gw2Calculator.Gw2Api
{
    public abstract class ApiClientBase
    {
        private const string _apiKey = "";
        private const string _baseUrl = "https://api.guildwars2.com";
        
        private HttpClient CreateClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl)
            };
            client.DefaultRequestHeaders.Clear();
            return client;
        }

        protected async Task<T> GetAsync<T>(string requestUri) where T : JToken
        {
            using (var client = CreateClient())
            {
                var response = await client.GetAsync($"{requestUri}?access_token={_apiKey}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(content);
                }
                return null;
            }
        }
    }
}
