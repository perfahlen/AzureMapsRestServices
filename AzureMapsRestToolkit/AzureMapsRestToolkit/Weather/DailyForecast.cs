using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class DailyForecast
    {
        /// <summary>
        /// airAndPollen
        /// </summary>
        [JsonPropertyName("airAndPollen")]
        public AirAndPollen[] AirAndPollen { get; set; }

        /// <summary>
        /// Date and time of the current observation displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// Day
        /// </summary>
        [JsonPropertyName("day")]
        public DayOrNight Day { get; set; }

        /// <summary>
        /// Summary of Heating Degree Day or Cooling Degree Day information
        /// </summary>
        [JsonPropertyName("degreeDaySummary")]
        public DegreeDaySummary DegreeDaySummary { get; set; }

        /// <summary>
        /// Hours of sun.
        /// </summary>
        [JsonPropertyName("hoursOfSun")]
        public double HoursOfSun { get; set; }

        /// <summary>
        /// Night
        /// </summary>
        [JsonPropertyName("night")]
        public DayOrNight Night { get; set; }

        /// <summary>
        /// RealFeel™ Temperature being returned.
        /// </summary>
        [JsonPropertyName("realFeelTemperature")]
        public WeatherUnitRange RealFeelTemperature { get; set; }

        /// <summary>
        /// RealFeel™ Temperature being returned. Describes what the temperature really feels like in the shade.
        /// </summary>
        [JsonPropertyName("realFeelTemperatureShade")]
        public WeatherUnitRange RealFeelTemperatureShade { get; set; }

        /// <summary>
        /// Source(s) of the forecast data.
        /// </summary>
        [JsonPropertyName("sources")]
        public string[] Sources { get; set; }

        /// <summary>
        /// Temperature values for the day.
        /// </summary>
        [JsonPropertyName("temperature")]
        public WeatherUnitRange Temperature { get; set; }



    }
}