using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class DegreeDaySummary
    {
        /// <summary>
        /// Number of degrees that the mean temperature is above 65 degrees F/ 18 degree C.
        /// </summary>
        [JsonPropertyName("cooling")]
        public WeatherUnit Cooling { get; set; }

        /// <summary>
        /// Number of degrees that the mean temperature is below 65 degrees F/ 18 degree C.
        /// </summary>
        [JsonPropertyName("heating")]
        public WeatherUnit Heating { get; set; }


    }
}