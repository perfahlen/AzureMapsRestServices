using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class PrecipitationSummary
    {
        /// <summary>
        /// The amount of precipitation (liquid equivalent) that has fallen in the past 12 hours.
        /// </summary>
        [JsonPropertyName("past12Hours")]
        public WeatherUnit Past12Hours { get; set; }

        /// <summary>
        /// The amount of precipitation (liquid equivalent) that has fallen in the past 18 hours.
        /// </summary>
        [JsonPropertyName("past18Hours")]
        public WeatherUnit Past18Hours { get; set; }

        /// <summary>
        /// The amount of precipitation (liquid equivalent) that has fallen in the past 24 hours.
        /// </summary>
        [JsonPropertyName("past24Hours")]
        public WeatherUnit Past24Hours { get; set; }

        /// <summary>
        /// The amount of precipitation (liquid equivalent) that has fallen in the past three hours.
        /// </summary>
        [JsonPropertyName("past3Hours")]
        public WeatherUnit Past3Hours { get; set; }

        /// <summary>
        /// The amount of precipitation (liquid equivalent) that has fallen in the past six hours. Contains Metric and Imperial Values.
        /// </summary>
        [JsonPropertyName("past6Hours")]
        public WeatherUnit Past6Hours { get; set; }

        /// <summary>
        /// The amount of precipitation (liquid equivalent) that has fallen in the past nine hours.
        /// </summary>
        [JsonPropertyName("past9Hours")]
        public WeatherUnit Past9Hours { get; set; }

        /// <summary>
        /// The amount of precipitation (liquid equivalent) that has fallen in the past hour.
        /// </summary>
        [JsonPropertyName("pastHour")]
        public WeatherUnit PastHour { get; set; }
    }
}
    