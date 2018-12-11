using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchNearbyResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonProperty("results")]
        public SearchNearbyPoiResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search Nearby response
        /// </summary>
        [JsonProperty("summary")]
        public SearchNearbySummary Summary { get; set; }
    }
}
