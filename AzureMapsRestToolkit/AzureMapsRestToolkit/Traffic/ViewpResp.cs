using Newtonsoft.Json;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// Viewport Response object
    /// </summary>
    public class ViewpResp
    {
        /// <summary>
        /// @maps property
        /// </summary>
        [JsonProperty("@maps")]
        public string Maps { get; set; }

        /// <summary>
        /// @Version property
        /// </summary>
        [JsonProperty("@version")]
        public string Version { get; set; }

        /// <summary>
        /// Copyright Ids property
        /// </summary>
        [JsonProperty("copyrightIds")]
        public string CopyrightIds { get; set; }

        /// <summary>
        /// Traffic State array
        /// </summary>
        [JsonProperty("trafficState")]
        public TrafficState TrafficState { get; set; }
    }
}