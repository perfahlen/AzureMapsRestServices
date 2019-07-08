using Newtonsoft.Json;

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
        [JsonProperty("distanceInMeters")]
        public double DistanceInMeters { get; set; }

        /// <summary>
        /// The unique id identifies a geometry
        /// </summary>
        [JsonProperty("geometryId")]
        public int GeometryId { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude
        /// </summary>
        [JsonProperty("position")]
        public Coordinate Position { get; set; }
    }
}