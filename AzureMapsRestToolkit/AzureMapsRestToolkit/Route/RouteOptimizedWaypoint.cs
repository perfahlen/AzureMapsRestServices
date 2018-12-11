using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Optimized way point object.
    /// </summary>
    public class RouteOptimizedWaypoint
    {
        /// <summary>
        /// Optimized way point index from the system.
        /// </summary>
        [JsonProperty("optimizedIndex")]
        public int OptimizedIndex { get; set; }

        /// <summary>
        /// Way point index provided by the user.
        /// </summary>
        [JsonProperty("providedIndex")]
        public int ProvidedIndex { get; set; }
    }
}
