using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport.
    /// </summary>
    public class SearchResultViewport
    {
        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonProperty("btmRightPoint")]
        public CoordinateAbbreviated BtmRightPoint { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonProperty("topLeftPoint")]
        public CoordinateAbbreviated TopLeftPoint { get; set; }
    }
}