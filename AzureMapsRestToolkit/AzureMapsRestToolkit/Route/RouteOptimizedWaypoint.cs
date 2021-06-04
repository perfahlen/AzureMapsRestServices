using System.Text.Json;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("optimizedIndex")]
        public int OptimizedIndex { get; set; }

        /// <summary>
        /// Way point index provided by the user.
        /// </summary>
        [JsonPropertyName("providedIndex")]
        public int ProvidedIndex { get; set; }
    }
}
