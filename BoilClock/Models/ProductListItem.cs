using System;
using Android.Runtime;
using Newtonsoft.Json;

namespace BoilClock.Models
{
    public class ProductListItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}