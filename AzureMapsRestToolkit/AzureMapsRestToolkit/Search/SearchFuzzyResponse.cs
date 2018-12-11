using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchFuzzyResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonProperty("results")]
        public SearchFuzzyResult[] Results { get; set; }


        /// <summary>
        /// Summary object for a Search Fuzzy response
        /// </summary>
        [JsonProperty("summary")]
        public SearchSummary Summary { get; set; }
    }
}
