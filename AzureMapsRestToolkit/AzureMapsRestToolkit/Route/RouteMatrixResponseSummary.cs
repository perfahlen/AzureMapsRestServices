using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteMatrixResponseSummary
    {
        [JsonPropertyName("lengthInMeters")]
        public int LengthInMeters { get; set; }

        [JsonPropertyName("travelTimeInSeconds")]
        public int TravelTimeInSeconds { get; set; }

        [JsonPropertyName("trafficDelayInSeconds")]
        public int TrafficDelayInSeconds { get; set; }

        [JsonPropertyName("departureTime")]
        public string DepartureTime { get; set; }

        [JsonPropertyName("arrivalTime")]
        public string ArrivalTime { get; set; }
    }
}
