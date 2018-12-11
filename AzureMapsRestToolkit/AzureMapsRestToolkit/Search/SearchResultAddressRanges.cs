using Newtonsoft.Json;
namespace AzureMapsToolkit.Search
{
    public class SearchResultAddressRanges
    {

        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonProperty("from")]
        public CoordinateAbbreviated From { get; set; }

        [JsonProperty("rangeLeft")]
        public string RangeLeft { get; set; }


        [JsonProperty("rangeRight")]
        public string RangeRight { get; set; }


        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonProperty("to")]
        public CoordinateAbbreviated To { get; set; }
    }
}
