using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Timezone
{
    public class TimezoneResult
    {
        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("ReferenceUtcTimestamp")]
        public string ReferenceUtcTimestamp { get; set; }

        [JsonPropertyName("TimeZones")]
        public Timezone[] TimeZones { get; set; }

        [JsonPropertyName("Version")]
        public string Version { get; set; }
    }
}
