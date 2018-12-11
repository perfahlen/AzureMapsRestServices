using Newtonsoft.Json;

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
        [JsonProperty("@trafficAge")]
        public int TrafficAge { get; set; }

        /// <summary>
        /// @Traffic Model Id property
        /// </summary>
        [JsonProperty("@trafficModelId")]
        public string TrafficModelId { get; set; }
    }
}