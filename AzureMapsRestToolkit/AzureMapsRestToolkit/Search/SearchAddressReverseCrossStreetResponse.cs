using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseCrossStreetResponse
    {
        /// <summary>
        /// Addresses array
        /// </summary>
        [JsonPropertyName("addresses")]
        public SearchAddressReverseResult[] Addresses { get; set; }

        /// <summary>
        /// Summary object for a Search Address Reverse Cross Street response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchAddressReverseSummary Summary { get; set; }


    }
}
