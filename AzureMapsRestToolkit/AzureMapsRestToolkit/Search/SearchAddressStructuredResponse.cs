using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressStructuredResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonPropertyName("results")]
        public SearchAddressStructuredResult[] Results { get; set; }

        /// <summary>
        /// Summary object for a Search Address Structured response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchAddressStructuredSummary Summary { get; set; }
    }
}
