using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteRangeResponse: RouteResponseBase
    {
        /// <summary>
        /// Reachable Range
        /// </summary>
        [JsonPropertyName("reachableRange")]
        public RouteRange ReachableRange { get; set; }
        
    }
}
