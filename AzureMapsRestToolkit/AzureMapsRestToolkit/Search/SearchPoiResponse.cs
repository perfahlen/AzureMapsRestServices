using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchPoiResponse
    {
        [JsonProperty("results")]
        public SearchNearbyPoiResult[] Results { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary")]
        public SearchSummary Summary { get; set; }
    }
}
