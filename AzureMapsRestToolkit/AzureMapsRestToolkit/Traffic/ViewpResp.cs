using System.Text.Json.Serialization;

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
        [JsonPropertyName("@maps")]
        public string Maps { get; set; }

        /// <summary>
        /// @Version property
        /// </summary>
        [JsonPropertyName("@version")]
        public string Version { get; set; }

        /// <summary>
        /// Copyright Ids property
        /// </summary>
        [JsonPropertyName("copyrightIds")]
        public string CopyrightIds { get; set; }

        /// <summary>
        /// Traffic State array
        /// </summary>
        [JsonPropertyName("trafficState")]
        public TrafficState TrafficState { get; set; }
    }
}