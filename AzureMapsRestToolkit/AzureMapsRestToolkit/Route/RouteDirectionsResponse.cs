using Newtonsoft.Json;

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
        [JsonProperty("routes")]
        public RouteDirectionsResult[] Routes { get; set; }


    }
}
