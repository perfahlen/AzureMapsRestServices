using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// This object is returned from a successful Search Address call
    /// </summary>
    public class SearchAddressResponse
    {
        /// <summary>
        /// Results array
        /// </summary>
        [JsonProperty("results")]
        public SearchAddressResult[] Results { get; set; }


        /// <summary>
        /// Summary object for a Search Address response
        /// </summary>
        [JsonProperty("summary")]
        public SearchSummary Summary { get; set; }
    }
}
