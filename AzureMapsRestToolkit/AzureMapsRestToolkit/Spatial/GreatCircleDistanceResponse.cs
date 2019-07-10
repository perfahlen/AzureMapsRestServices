using Newtonsoft.Json;

namespace AzureMapsToolkit.Spatial
{
    public class GreatCircleDistanceResponse : SpatialRequestBase
    {
        /// <summary>
        /// Result Object
        /// </summary>
        [JsonProperty("result")]
        public Result Result { get; set; }

        /// <summary>
        /// Summary object
        /// </summary>
        [JsonProperty("summary")]
        public Summary Summary { get; set; }
    }
}
