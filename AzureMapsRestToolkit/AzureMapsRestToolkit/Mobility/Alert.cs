using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AzureMapsToolkit.Mobility
{
    public class Alert
    {
        /// <summary>
        /// The level at which the respective alert extents to. One of Metro, Agency, Line, Stop.
        /// </summary>
        [JsonProperty("alertLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AlertLevel AlertLevel { get; set; }

        /// <summary>
        /// Text summarizing the alert.
        /// </summary>
        [JsonProperty("alertSummary")]
        public string AlertSummary { get; set; }

        /// <summary>
        /// The category of the alert. One of None, Regular, Info, Modified, Critical.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
    }
}