using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressStructuredResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonProperty("results")]
        public SearchAddressStructuredResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search Address Structured response
        /// </summary>
        [JsonProperty("summary")]
        public SearchAddressStructuredSummary Summary { get; set; }
    }
}
