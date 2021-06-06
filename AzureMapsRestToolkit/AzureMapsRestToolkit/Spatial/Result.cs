using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    public class Result
    {
        /// <summary>
        /// The great circle distance in meters from the source point to the target point
        /// </summary>
        [JsonPropertyName("distanceInMeters")]
        public double DistanceInMeters { get; set; }
    }
}