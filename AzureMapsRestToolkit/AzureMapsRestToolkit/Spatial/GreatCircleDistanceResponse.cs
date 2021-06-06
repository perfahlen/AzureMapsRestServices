using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    public class GreatCircleDistanceResponse : SpatialRequestBase
    {
        /// <summary>
        /// Result Object
        /// </summary>
        [JsonPropertyName("result")]
        public Result Result { get; set; }

        /// <summary>
        /// Summary object
        /// </summary>
        [JsonPropertyName("summary")]
        public Summary Summary { get; set; }
    }
}
