using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseResult
    {
        /// <summary>
        /// The address of the result
        /// </summary>
        [JsonProperty("address")]
        public SearchResultAddress Address { get; set; }

        /// <summary>
        /// Position property in the form of "{latitude},{longitude}"
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }
    }
}
