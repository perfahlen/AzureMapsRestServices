using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchPoiResponse
    {
        [JsonPropertyName("results")]
        public SearchNearbyPoiResult[] Results { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchSummary Summary { get; set; }
    }
}
