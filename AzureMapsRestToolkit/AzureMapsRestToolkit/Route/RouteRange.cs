using Newtonsoft.Json;

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
        [JsonProperty("boundary")]
        public Coordinate[] Boundary { get; set; }


        /// <summary>
        /// Center point of the reachable range
        /// </summary>
        [JsonProperty("center")]
        public Coordinate Center { get; set; }
    }
}
