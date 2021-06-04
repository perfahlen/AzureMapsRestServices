using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseResult
    {
        /// <summary>
        /// The address of the result
        /// </summary>
        [JsonPropertyName("address")]
        public SearchResultAddress Address { get; set; }

        /// <summary>
        /// Position property in the form of "{latitude},{longitude}"
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; }
    }
}
