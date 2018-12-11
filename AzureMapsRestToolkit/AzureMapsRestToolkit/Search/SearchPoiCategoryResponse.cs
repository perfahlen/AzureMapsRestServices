using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// This object is returned from a successful Search POI Category call
    /// </summary>
    public class SearchPoiCategoryResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonProperty("results")]
        public SearchNearbyPoiResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search POI Category response
        /// </summary>
        [JsonProperty("summary")]
        public SearchSummary Summary { get; set; }
    }
}
