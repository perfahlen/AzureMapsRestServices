using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    public class TrafficRequestTileBase: RequestBase
    {
        /// <summary>
        /// Zoom level for the desired tile. Zoom value must be in the range: 0-18 (inclusive).
        /// </summary>
        [JsonPropertyName("zoom")]
        public int Zoom { get; set; }

        /// <summary>
        /// X coordinate of the tile on zoom grid. Value must be in the range [0, 2zoom -1].
        /// </summary>
        [JsonPropertyName("x")]
        public int X { get; set; }

        /// <summary>
        /// Y coordinate of the tile on zoom grid. Value must be in the range [0, 2zoom -1].
        /// </summary>
        [JsonPropertyName("y")]
        public int Y { get; set; }
    }
}
