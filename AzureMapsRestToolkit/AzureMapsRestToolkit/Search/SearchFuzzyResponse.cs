using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchFuzzyResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonPropertyName("results")]
        public SearchFuzzyResult[] Results { get; set; }


        /// <summary>
        /// Summary object for a Search Fuzzy response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchSummary Summary { get; set; }
    }
}
