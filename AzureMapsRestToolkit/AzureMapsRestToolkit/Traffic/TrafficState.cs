using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// Traffic State array
    /// </summary>
    public class TrafficState
    {
        /// <summary>
        /// @Traffic Age property
        /// </summary>
        [JsonPropertyName("@trafficAge")]
        public int TrafficAge { get; set; }

        /// <summary>
        /// @Traffic Model Id property
        /// </summary>
        [JsonPropertyName("@trafficModelId")]
        public string TrafficModelId { get; set; }
    }
}