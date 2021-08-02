using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class WeatherAlongRouteResponse
    {
        [JsonPropertyName("summary")]
        public WeatherAlongRouteSummary Summary { get; set; }

        /// <summary>
        /// Data for each waypoint returned in the same order as specified in the request.
        /// </summary>
        [JsonPropertyName("waypoints")]
        public Waypoint[] Waypoints { get; set; }
    }
}
