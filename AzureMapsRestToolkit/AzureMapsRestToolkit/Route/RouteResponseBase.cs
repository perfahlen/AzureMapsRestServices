using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteResponseBase
    {
        /// <summary>
        /// Copyright property
        /// </summary>
        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Format Version property
        /// </summary>
        [JsonPropertyName("formatVersion")]
        public string FormatVersion { get; set; }

        /// <summary>
        /// Optimized sequence of waypoints. It shows the index from the user provided waypoint sequence for the original and optimized list. For instance, a response:
        /// </summary>
        [JsonPropertyName("optimizedWaypoints")]
        public RouteOptimizedWaypoint[] OptimizedWaypoints { get; set; }

        /// <summary>
        /// Privacy property
        /// </summary>
        [JsonPropertyName("privacy")]
        public string Privacy { get; set; }

        /// <summary>
        /// Reports the effective settings used in the current call.
        /// </summary>
        [JsonPropertyName("report")]
        public RouteResponseReport Report { get; set; }

    }
}
