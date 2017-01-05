using Newtonsoft.Json;

namespace BoilClock.Models
{
    public class Timer
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }
}