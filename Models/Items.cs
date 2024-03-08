

using Newtonsoft.Json;

namespace EldenRing.Models
{
    public class Items
    {
        public string Name { get; set; }
        [JsonProperty("image")]
        public string ImageUrl { get; set; }

        public string Description  { get; set; }
    }

}

