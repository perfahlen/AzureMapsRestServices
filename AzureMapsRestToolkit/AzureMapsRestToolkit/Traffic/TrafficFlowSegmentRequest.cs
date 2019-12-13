using AzureMapsToolkit.Common;
using Newtonsoft.Json;

namespace AzureMapsToolkit.Traffic
{
    public class TrafficFlowSegmentRequest : RequestBase
    {
        /// <summary>
        /// Zoom level for the desired tile. Zoom value must be in the range: 0-18 (inclusive).
        /// </summary>
        public int Zoom { get; set; } = 0;

        /// <summary>
        /// Coordinates of the point close to the road segment. They have to be comma-separated and calculated using EPSG4326 projection.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Unit of speed in KMPH or MPH
        /// </summary>
        public SpeedUnit Unit { get; set; }

        /// <summary>
        /// The segment width multiplier. Default: 10, minimum: 1 and maximum: 20
        /// </summary>
        public int Thickness { get; set; } = 10;

        /// <summary>
        /// Boolean on whether the response should include OpenLR code
        /// </summary>
        public bool? OpenLr { get; set; }

        /// <summary>
        /// The style to be used to render the tile. Valid values are absolute which returns colors reflecting the absolute speed measured, relative which returns the speed relative to free-flow, Relative-delay which displays relative speeds only where they are different from the freeflow speeds
        /// </summary>
        [JsonProperty("style")]
        public TrafficFlowSegmentStyle Style { get; set; }
    }
}
 