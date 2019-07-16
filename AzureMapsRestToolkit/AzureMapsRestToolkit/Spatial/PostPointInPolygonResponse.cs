using Newtonsoft.Json;

namespace AzureMapsToolkit.Spatial
{
    public class PostPointInPolygonResponse
    {
        /// <summary>
        /// Point In Polygon Result Object
        /// </summary>
        [JsonProperty("result")]
        public PointInPolygonResult Result { get; set; }

        /// <summary>
        /// Point In Polygon Summary object
        /// </summary>
        [JsonProperty("summary")]
        public PostPointInPolygonSummary Summary { get; set; }
    }
}
