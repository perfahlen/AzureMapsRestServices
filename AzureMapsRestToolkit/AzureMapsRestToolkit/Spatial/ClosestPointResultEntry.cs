using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    /// <summary>
    /// Closest Point Result Entry Object
    /// </summary>
    public class ClosestPointResultEntry
    {
        /// <summary>
        /// The distance in meters from the source point to the closest point
        /// </summary>
        [JsonPropertyName("distanceInMeters")]
        public double DistanceInMeters { get; set; }

        /// <summary>
        /// The unique id identifies a geometry
        /// </summary>
        [JsonPropertyName("geometryId")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int GeometryId { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude
        /// </summary>
        [JsonPropertyName("position")]
        public Coordinate Position { get; set; }
    }
}