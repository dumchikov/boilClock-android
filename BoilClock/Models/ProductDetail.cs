using System.Collections.Generic;
using Newtonsoft.Json;

namespace BoilClock.Models
{
    public class ProductDetail
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("timers")]
        public IEnumerable<Timer> Timers { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }
    }
}