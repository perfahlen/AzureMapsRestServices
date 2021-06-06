using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Reachable Range
    /// </summary>
    public class RouteRange
    {
        /// <summary>
        /// Polygon boundary of the reachable range represented as a list of points.
        /// </summary>
        [JsonPropertyName("boundary")]
        public Coordinate[] Boundary { get; set; }


        /// <summary>
        /// Center point of the reachable range
        /// </summary>
        [JsonPropertyName("center")]
        public Coordinate Center { get; set; }
    }
}
