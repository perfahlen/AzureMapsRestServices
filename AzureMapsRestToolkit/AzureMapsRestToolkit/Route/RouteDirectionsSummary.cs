using Newtonsoft.Json;

namespace AzureMapsToolkit.Common
{
    public class RouteDirectionsSummary
    {
        /// <summary>
        /// Arrival Time property
        /// </summary>
        [JsonProperty("arrivalTime")]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Departure Time property
        /// </summary>
        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Length In Meters property
        /// </summary>
        [JsonProperty("lengthInMeters")]
        public int LengthInMeters { get; set; }

        /// <summary>
        /// Traffic Delay In Seconds property
        /// </summary>
        [JsonProperty("trafficDelayInSeconds")]
        public int TrafficDelayInSeconds { get; set; }

        /// <summary>
        /// Travel Time In Seconds property
        /// </summary>
        [JsonProperty("travelTimeInSeconds")]
        public int TravelTimeInSeconds { get; set; }
    }
}
