using Newtonsoft.Json;

namespace BoilClock.Models
{
    public class Category
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}