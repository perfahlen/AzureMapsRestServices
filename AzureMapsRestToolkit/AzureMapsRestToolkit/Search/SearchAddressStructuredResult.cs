using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressStructuredResult : SearchResult
    {

        /// <summary>
        /// Describes the address range on both sides of the street for a search result. Coordinates for the start and end locations of the address range are included.
        /// </summary>
        [JsonPropertyName("addressRanges")]
        public SearchResultAddressRanges AddressRanges { get; set; }

        /// <summary>
        /// Straight line distance between the result and geobias location in meters.
        /// </summary>
        [JsonPropertyName("dist")]
        public double Dist { get; set; }

        /// <summary>
        /// Info property
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }
    }
}
