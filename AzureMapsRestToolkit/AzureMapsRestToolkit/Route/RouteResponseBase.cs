using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteResponseBase
    {
        /// <summary>
        /// Copyright property
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Format Version property
        /// </summary>
        [JsonProperty("formatVersion")]
        public string FormatVersion { get; set; }

        /// <summary>
        /// Optimized sequence of waypoints. It shows the index from the user provided waypoint sequence for the original and optimized list. For instance, a response:
        /// </summary>
        [JsonProperty("optimizedWaypoints")]
        public RouteOptimizedWaypoint[] OptimizedWaypoints { get; set; }

        /// <summary>
        /// Privacy property
        /// </summary>
        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        /// <summary>
        /// Reports the effective settings used in the current call.
        /// </summary>
        [JsonProperty("report")]
        public RouteResponseReport Report { get; set; }

    }
}
