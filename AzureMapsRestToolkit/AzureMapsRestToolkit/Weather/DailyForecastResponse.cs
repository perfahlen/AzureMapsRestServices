using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class DailyForecastResponse
    {
        /// <summary>
        /// Forecast data for each requested day.
        /// </summary>
        [JsonPropertyName("forecasts")]
        public DailyForecast[] Forecasts { get; set; }

        /// <summary>
        /// Summary for the main conditions for the requested time period. Notice that summary can cover only part of the time period.
        /// </summary>
        [JsonPropertyName("summary")]
        public DailyForecastSummary Summary { get; set; }
    }
}
