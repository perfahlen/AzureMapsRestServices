using System.Text.Json.Serialization;

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
        [JsonPropertyName("results")]
        public SearchAddressResult[] Results { get; set; }


        /// <summary>
        /// Summary object for a Search Address response
        /// </summary>
        [JsonPropertyName("summary")]
        public SearchSummary Summary { get; set; }
    }
}
