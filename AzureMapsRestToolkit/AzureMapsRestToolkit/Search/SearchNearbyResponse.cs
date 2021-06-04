using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchNearbyResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonPropertyName("results")]
        public SearchNearbyPoiResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search Nearby response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchNearbySummary Summary { get; set; }
    }
}
