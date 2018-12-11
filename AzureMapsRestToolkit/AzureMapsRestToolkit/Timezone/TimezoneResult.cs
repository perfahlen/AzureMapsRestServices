using Newtonsoft.Json;

namespace AzureMapsToolkit.Timezone
{
    public class TimezoneResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("referenceUtcTimestamp")]
        public string ReferenceUtcTimestamp { get; set; }

        [JsonProperty("timeZones")]
        public Timezone[] TimeZones { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
