using System.Text.Json.Serialization;

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
        [JsonPropertyName("results")]
        public SearchNearbyPoiResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search POI Category response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchSummary Summary { get; set; }
    }
}
