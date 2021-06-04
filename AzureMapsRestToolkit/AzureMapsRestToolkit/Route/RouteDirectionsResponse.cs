using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// This object is returned from a successful Route Directions call
    /// </summary>
    public class RouteDirectionsResponse : RouteResponseBase
    {

        /// <summary>
        /// Routes array
        /// </summary>
        [JsonPropertyName("routes")]
        public RouteDirectionsResult[] Routes { get; set; }


    }
}
