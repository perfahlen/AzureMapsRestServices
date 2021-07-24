using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class MinuteForecastResponse
    {
        /// <summary>
        /// Summary information for each interval in the forecast. The Summaries breaks down each potential interval where precipitation starts and stops.
        /// </summary>
        [JsonPropertyName("intervalSummaries")]
        public IntervalSummary[] IntervalSummaries { get; set; }

        /// <summary>
        /// Forecast data for each interval in the forecast.
        /// </summary>
        [JsonPropertyName("Intervals")]
        public Interval[] Intervals { get; set; }

        /// <summary>
        /// Phrase summaries for the entire forecast period.
        /// </summary>
        [JsonPropertyName("summary")]
        public MinuteForecastSummary Summary { get; set; }
    }
}
