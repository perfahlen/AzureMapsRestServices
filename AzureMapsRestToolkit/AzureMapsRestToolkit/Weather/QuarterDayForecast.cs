using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class QuarterDayForecast
    {

        /// <summary>
        /// Percent representing cloud cover.
        /// </summary>
        [JsonPropertyName("cloudCover")]
        public int CloudCover { get; set; }

        /// <summary>
        /// Date and time of the forecast in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// The dewpoint temperature in specified unit. The dewpoint temperature is the temperature that the air must be cooled to in order to reach saturation.
        /// </summary>
        [JsonPropertyName("dewPoint")]
        public WeatherUnit DewPoint { get; set; }

        /// <summary>
        /// Date and time of the beginning of the forecast quarter displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("effectiveDate")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Indicates the presence or absence of precipitation. True indicates the presence of precipitation, false indicates the absence of precipitation.
        /// </summary>
        [JsonPropertyName("hasPrecipitation")]
        public bool HasPrecipitation { get; set; }

        /// <summary>
        /// Ice
        /// </summary>
        [JsonPropertyName("ice")]
        public WeatherUnit Ice { get; set; }

        /// <summary>
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        /// <summary>
        /// Phrase description of the icon. Displayed in specified language. For example, 'Sunny'.
        /// </summary>
        [JsonPropertyName("iconPhrase")]
        public string IconPhrase { get; set; }

        /// <summary>
        /// Short summary phrase summary for quarter.
        /// </summary>
        [JsonPropertyName("phrase")]
        public string Phrase { get; set; }

        /// <summary>
        /// Description of the intensity.
        /// </summary>
        [JsonPropertyName("precipitationIntensity")]
        public string PrecipitationIntensity { get; set; }

        /// <summary>
        /// Percent representing the probability of precipitation. For example, '20'.
        /// </summary>
        [JsonPropertyName("precipitationProbability")]
        public int PrecipitationProbability { get; set; }

        /// <summary>
        /// "Specifies the type of precipitation (""rain"" ""snow"" ""ice"" or ""mix""). If dbz = zero, precipitationType is not present in the response."
        /// </summary>
        [JsonPropertyName("precipitationType")]
        public string PrecipitationType { get; set; }

        /// <summary>
        /// Quarter of the day.
        /// </summary>
        [JsonPropertyName("quarter")]
        public Quarter Quarter { get; set; }

        /// <summary>
        /// Rain
        /// </summary>
        [JsonPropertyName("rain")]
        public WeatherUnit Rain { get; set; }

        /// <summary>
        /// RealFeel™ Temperature values for the quarter.
        /// </summary>
        [JsonPropertyName("realFeelTemperature")]
        public WeatherUnitRange RealFeelTemperature { get; set; }

        /// <summary>
        /// Relative humidity is the amount of water vapor present in air expressed as a percentage of the amount needed for saturation at the same temperature.
        /// </summary>
        [JsonPropertyName("relativeHumidity")]
        public int RelativeHumidity { get; set; }

        /// <summary>
        /// Snow
        /// </summary>
        [JsonPropertyName("snow")]
        public WeatherUnit Snow { get; set; }

        /// <summary>
        /// Temperature values for the quarter.
        /// </summary>
        [JsonPropertyName("temperature")]
        public WeatherUnitRange Temperature { get; set; }

        /// <summary>
        /// Percent representing the probability of a thunderstorm. For example, '10'.
        /// </summary>
        [JsonPropertyName("thunderstormProbability")]
        public int ThunderstormProbability { get; set; }

        /// <summary>
        /// Total liquid equivalent of precipitation during the forecast period.
        /// </summary>
        [JsonPropertyName("totalLiquid")]
        public WeatherUnit TotalLiquid { get; set; }

        /// <summary>
        /// Visibility in specified unit. A measure of the distance at which an object or light can be clearly discerned.
        /// </summary>
        [JsonPropertyName("visibility")]
        public WeatherUnit Visibility { get; set; }

        /// <summary>
        /// Wind details being returned including speed and direction.
        /// </summary>
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// Wind gust. Wind gust is a sudden, brief increase in speed of the wind.
        /// </summary>
        [JsonPropertyName("windGust")]
        public Wind WindGust { get; set; }


    }
}
