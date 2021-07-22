using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Elevation
{
    public class PointElevationResult
    {
        /// <summary>
        /// The elevation value in meters.
        /// </summary>
        [JsonPropertyName("elevationInMeter")]
        public double ElevationInMeter { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonPropertyName("coordinate")]
        public Coordinate Coordinate { get; set; }
    }
}