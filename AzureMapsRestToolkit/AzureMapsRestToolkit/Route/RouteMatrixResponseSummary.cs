using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrixResponseSummary
    {
        [JsonProperty("lengthInMeters")]
        public int LengthInMeters { get; set; }

        [JsonProperty("travelTimeInSeconds")]
        public int TravelTimeInSeconds { get; set; }

        [JsonProperty("trafficDelayInSeconds")]
        public int TrafficDelayInSeconds { get; set; }

        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }

        [JsonProperty("arrivalTime")]
        public string arrivalTime { get; set; }
    }
}
