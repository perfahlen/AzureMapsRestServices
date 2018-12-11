using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseResponse
    {
        /// <summary>
        /// Addresses array
        /// </summary>
        [JsonProperty("addresses")]
        public SearchAddressReverseResult[] Addresses { get; set; }

        /// <summary>
        /// Summary object for a Search Address Reverse response
        /// </summary>
        [JsonProperty("summary")]
        public SearchAddressReverseSummary Summary { get; set; }
    }
}
