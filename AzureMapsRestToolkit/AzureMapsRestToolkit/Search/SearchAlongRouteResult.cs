using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAlongRouteResult : SearchNearbyPoiResult
    {
        /// <summary>
        /// Detour time in seconds
        /// </summary>
        [JsonProperty("detourTime")]
        public int DetourTime { get; set; }


        /// <summary>
        /// Entity Type property
        /// </summary>
        [JsonProperty("entityType")]
        public string EntityType { get; set; }
    }
}