using EldenRing.Models;
using Newtonsoft.Json;
using static EldenRing.Models.Response;

namespace EldenRing.Services
{
    public class ApiService
    {
        public static async Task<List<Items>> FetchItemsAsync()
        {
            var url = "https://eldenring.fanapis.com/api/items?";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                var apiResponse = JsonConvert.DeserializeObject<Response>(response);
                return apiResponse.Data;
            }
        }
    }
}
