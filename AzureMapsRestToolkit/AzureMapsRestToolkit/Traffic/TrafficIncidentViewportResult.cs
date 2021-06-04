using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    /// <summary>
    /// This object is returned from a successful Traffic Incident Viewport call
    /// </summary>
    public class TrafficIncidentViewportResult
    {
        /// <summary>
        /// Viewport Response object
        /// </summary>
        [JsonPropertyName("viewpResp")]
        public ViewpResp ViewpResp { get; set; }
    }
}
