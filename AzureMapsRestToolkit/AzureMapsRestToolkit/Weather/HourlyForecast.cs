using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class HourlyForecast
    {
       
        /// <summary>
        /// Cloud ceiling in specified unit. The ceiling is a measurement of the height of the base of the lowest clouds.
        /// </summary>
        [JsonPropertyName("ceiling")]
        public WeatherUnit Ceiling { get; set; }

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
        /// Percent representing the probability of snow. For example, '5'.
        /// </summary>
        [JsonPropertyName("iceProbability")]
        public int IceProbability { get; set; }

        /// <summary>
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        /// <summary>
        /// Phrase description of the weather icon.
        /// </summary>
        [JsonPropertyName("iconPhrase")]
        public string IconPhrase { get; set; }

        /// <summary>
        /// Specifies whether or not it is daylight. True indicates day light.
        /// </summary>
        [JsonPropertyName("isDaylight")]
        public bool IsDaylight { get; set; }

        /// <summary>
        /// Percent representing the probability of precipitation. For example, '20'.
        /// </summary>
        [JsonPropertyName("precipitationProbability")]
        public int PrecipitationProbability { get; set; }

        /// <summary>
        /// Rain
        /// </summary>
        [JsonPropertyName("rain")]
        public WeatherUnit Rain { get; set; }

        /// <summary>
        /// Percent representing the probability of rain. For example, '50'.
        /// </summary>
        [JsonPropertyName("rainProbability")]
        public int RainProbability { get; set; }

        /// <summary>
        /// RealFeel™ Temperature being returned. Describes what the temperature really feels like in the shade.
        /// </summary>
        [JsonPropertyName("realFeelTemperature")]
        public WeatherUnit RealFeelTemperature { get; set; }

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
        /// Percent representing the probability of snow. For example, '50'.
        /// </summary>
        [JsonPropertyName("snowProbability")]
        public int SnowProbability { get; set; }

        /// <summary>
        /// Temperature being returned.
        /// </summary>
        [JsonPropertyName("temperature")]
        public WeatherUnit Temperature { get; set; }

        /// <summary>
        /// Total liquid equivalent of precipitation during the forecast period.
        /// </summary>
        [JsonPropertyName("totalLiquid")]
        public WeatherUnit TotalLiquid { get; set; }

        /// <summary>
        /// Measure of the strength of the ultraviolet radiation from the sun. Supported values are: 0-2 - Low danger from the sun's UV rays or the average person. 3-5 - Moderate risk of harm from unprotected sun exposure. 6-7 - High risk of harm from unprotected sun exposure. 8-10 - Very high risk of harm from unprotected sun exposure. 11+ - Extreme risk of harm from unprotected sun exposure.
        /// </summary>
        [JsonPropertyName("uvIndex")]
        public int UvIndex { get; set; }

        /// <summary>
        /// Phrase associated with the uvIndex.
        /// </summary>
        [JsonPropertyName("uvIndexPhrase")]
        public string UvIndexPhrase { get; set; }

        /// <summary>
        /// Visibility in specified unit. A measure of the distance at which an object or light can be clearly discerned.
        /// </summary>
        [JsonPropertyName("visibility")]
        public WeatherUnit Visibility { get; set; }

        /// <summary>
        /// The temperature to which air may be cooled by evaporating water into it at constant pressure until it reaches saturation.
        /// </summary>
        [JsonPropertyName("wetBulbTemperature")]
        public WeatherUnit WetBulbTemperature { get; set; }

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