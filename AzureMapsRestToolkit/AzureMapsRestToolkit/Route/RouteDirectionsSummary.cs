using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class RouteDirectionsSummary
    {
        /// <summary>
        /// Arrival Time property
        /// </summary>
        [JsonPropertyName("arrivalTime")]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Departure Time property
        /// </summary>
        [JsonPropertyName("departureTime")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Length In Meters property
        /// </summary>
        [JsonPropertyName("lengthInMeters")]
        public int LengthInMeters { get; set; }

        /// <summary>
        /// Traffic Delay In Seconds property
        /// </summary>
        [JsonPropertyName("trafficDelayInSeconds")]
        public int TrafficDelayInSeconds { get; set; }

        /// <summary>
        /// Travel Time In Seconds property
        /// </summary>
        [JsonPropertyName("travelTimeInSeconds")]
        public int TravelTimeInSeconds { get; set; }
    }
}
