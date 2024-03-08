using EldenRing.Models;
using Newtonsoft.Json;


namespace EldenRing.Services
{
    public class ApiService
    {
        public static async Task<Response> FetchItemsAsync()
        {
            var url = "https://eldenring.fanapis.com/api/items?";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                var apiResponse = JsonConvert.DeserializeObject<Response>(response);
                return apiResponse;
            }
        }
    }
}
