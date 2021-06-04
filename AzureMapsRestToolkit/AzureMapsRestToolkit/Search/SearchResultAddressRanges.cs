using System.Text.Json.Serialization;
namespace AzureMapsToolkit.Search
{
    public class SearchResultAddressRanges
    {

        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonPropertyName("from")]
        public CoordinateAbbreviated From { get; set; }

        [JsonPropertyName("rangeLeft")]
        public string RangeLeft { get; set; }


        [JsonPropertyName("rangeRight")]
        public string RangeRight { get; set; }


        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonPropertyName("to")]
        public CoordinateAbbreviated To { get; set; }
    }
}
