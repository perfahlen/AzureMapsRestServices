using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    public class TrafficFlowTileRequest : TrafficRequestTileBase
    {
       

        /// <summary>
        /// The value of the width of the line representing traffic. This value is a multiplier and the accepted values range from 1 - 20. The default value is 10.
        /// </summary>
        [JsonPropertyName("thickness")]
        public int? Thickness { get; set; } = 1;

        /// <summary>
        /// The style to be used to render the tile. Valid values are absolute which returns colors reflecting the absolute speed measured, relative which returns the speed relative to free-flow, Relative-delay which displays relative speeds only where they are different from the freeflow speeds
        /// </summary>
        [JsonPropertyName("style")]
        public TrafficFlowSegmentStyle Style { get; set; }
    }
}
