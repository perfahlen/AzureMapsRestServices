using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    public class GetPointInPolygonSummary
    {
        /// <summary>
        /// Processing information
        /// </summary>
        [JsonPropertyName("information")]
        public string Information { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude
        /// </summary>
        [JsonPropertyName("sourcePoint")]
        public Coordinate SourcePoint { get; set; }


        /// <summary>
        /// A unique data id (udid) for the uploaded content
        /// </summary>
        [JsonPropertyName("udid")]
        public string Udid { get; set; }
    }
}