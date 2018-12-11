using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteResultLeg
    {
        /// <summary>
        /// Points array
        /// </summary>
        [JsonProperty("points")]
        public Coordinate[] Points { get; set; }

        /// <summary>
        /// Summary object for route section.
        /// </summary>
        [JsonProperty("summary")]
        public RouteResultLegSummary Summary { get; set; }
    }
}
