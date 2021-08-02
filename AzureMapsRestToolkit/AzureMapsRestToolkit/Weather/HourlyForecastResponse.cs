using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class HourlyForecastResponse
    {
        /// <summary>
        /// Forecast data for each returned hour.
        /// </summary>
        [JsonPropertyName("forecasts")]
        public HourlyForecast[] Forecasts { get; set; }
    }
}
