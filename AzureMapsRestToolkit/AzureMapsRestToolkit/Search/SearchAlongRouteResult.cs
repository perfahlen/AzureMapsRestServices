using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchAlongRouteResult : SearchNearbyPoiResult
    {
        /// <summary>
        /// Detour time in seconds
        /// </summary>
        [JsonPropertyName("detourTime")]
        public int DetourTime { get; set; }


        /// <summary>
        /// Entity Type property
        /// </summary>
        [JsonPropertyName("entityType")]
        public string EntityType { get; set; }
    }
}