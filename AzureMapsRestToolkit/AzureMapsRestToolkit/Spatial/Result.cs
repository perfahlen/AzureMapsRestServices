using Newtonsoft.Json;

namespace AzureMapsToolkit.Spatial
{
    public class Result
    {
        /// <summary>
        /// The great circle distance in meters from the source point to the target point
        /// </summary>
        [JsonProperty("distanceInMeters")]
        public double DistanceInMeters { get; set; }
    }
}