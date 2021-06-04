using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    public class PostPointInPolygonResponse
    {
        /// <summary>
        /// Point In Polygon Result Object
        /// </summary>
        [JsonPropertyName("result")]
        public PointInPolygonResult Result { get; set; }

        /// <summary>
        /// Point In Polygon Summary object
        /// </summary>
        [JsonPropertyName("summary")]
        public PostPointInPolygonSummary Summary { get; set; }
    }
}
