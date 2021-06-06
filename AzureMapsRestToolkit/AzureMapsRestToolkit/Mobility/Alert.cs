using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    public class Alert
    {
        /// <summary>
        /// The level at which the respective alert extents to. One of Metro, Agency, Line, Stop.
        /// </summary>
        [JsonPropertyName("alertLevel")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AlertLevel AlertLevel { get; set; }

        /// <summary>
        /// Text summarizing the alert.
        /// </summary>
        [JsonPropertyName("alertSummary")]
        public string AlertSummary { get; set; }

        /// <summary>
        /// The category of the alert. One of None, Regular, Info, Modified, Critical.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }
    }
}