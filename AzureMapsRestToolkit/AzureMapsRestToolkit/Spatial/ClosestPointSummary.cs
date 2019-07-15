using Newtonsoft.Json;

namespace AzureMapsToolkit.Spatial
{
    /// <summary>
    /// Get Closest Point Summary object
    /// </summary>
    public class ClosestPointSummary
    {
        /// <summary>
        /// Processing information
        /// </summary>
        [JsonProperty("information")]
        public string Information { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude
        /// </summary>
        [JsonProperty("sourcePoint")]
        public Coordinate SourcePoint { get; set; }

        /// <summary>
        /// A unique data id (udid) for the uploaded content
        /// </summary>
        [JsonProperty("udid")]
        public string Udid { get; set; }
    }
}