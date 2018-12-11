using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteRangeResponse: RouteResponseBase
    {
        /// <summary>
        /// Reachable Range
        /// </summary>
        [JsonProperty("reachableRange")]
        public RouteRange ReachableRange { get; set; }
        
    }
}
