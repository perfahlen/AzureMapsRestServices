using AzureMapsToolkit.Common;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport.
    /// </summary>
    public class ResultViewport
    {
        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonPropertyName("btmRightPoint")]
        public Coordinate BtmRightPoint { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonPropertyName("topLeftPoint")]
        public Coordinate TopLeftPoint { get; set; }
    }
}