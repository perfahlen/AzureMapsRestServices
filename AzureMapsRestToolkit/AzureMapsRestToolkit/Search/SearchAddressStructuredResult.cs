using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressStructuredResult : SearchResult
    {

        /// <summary>
        /// Describes the address range on both sides of the street for a search result. Coordinates for the start and end locations of the address range are included.
        /// </summary>
        [JsonProperty("addressRanges")]
        public SearchResultAddressRanges AddressRanges { get; set; }

        /// <summary>
        /// Straight line distance between the result and geobias location in meters.
        /// </summary>
        [JsonProperty("dist")]
        public double Dist { get; set; }

        /// <summary>
        /// Info property
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }
    }
}
