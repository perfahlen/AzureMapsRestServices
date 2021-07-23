using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class CurrentConditions
    {
        /// <summary>
        /// Perceived outdoor temperature caused by the combination of air temperature, relative humidity, and wind speed in specified unit.
        /// </summary>
        [JsonPropertyName("apparentTemperature")]
        public WeatherUnit ApparentTemperature { get; set; }

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
        /// Date and time of the current observation displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public string DateTime { get; set; }

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
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        /// <summary>
        /// Indicates the time of the day. True indicates 'day',', false indicates 'night.
        /// </summary>
        [JsonPropertyName("isDayTime")]
        public bool IsDayTime { get; set; }

        /// <summary>
        /// Cause of limited visibility.
        /// </summary>
        [JsonPropertyName("obstructionsToVisibility")]
        public string ObstructionsToVisibility { get; set; }

        /// <summary>
        /// Departure from the temperature observed 24 hours ago in specified unit.
        /// </summary>
        [JsonPropertyName("past24HourTemperatureDeparture")]
        public WeatherUnit Past24HourTemperatureDeparture { get; set; }

        /// <summary>
        /// Phrase description of the current weather condition. Displayed in specified language.
        /// </summary>
        [JsonPropertyName("phrase")]
        public string Phrase { get; set; }

        /// <summary>
        /// Departure from the temperature observed 24 hours ago in specified unit.
        /// </summary>
        [JsonPropertyName("precipitationSummary")]
        public PrecipitationSummary PrecipitationSummary { get; set; }

        /// <summary>
        /// Atmospheric pressure in specified unit.
        /// </summary>
        [JsonPropertyName("pressure")]
        public WeatherUnit Pressure { get; set; }

        /// <summary>
        /// Atmospheric pressure change.
        /// </summary>
        [JsonPropertyName("pressureTendency")]
        public PressureTendency PressureTendency { get; set; }

        /// <summary>
        /// RealFeel™ Temperature being returned.
        /// </summary>
        [JsonPropertyName("realFeelTemperature")]
        public WeatherUnit RealFeelTemperature { get; set; }

        /// <summary>
        /// RealFeel™ Temperature being returned. Describes what the temperature really feels like in the shade.
        /// </summary>
        [JsonPropertyName("realFeelTemperatureShade")]
        public WeatherUnit RealFeelTemperatureShade { get; set; }

        [JsonPropertyName("relativeHumidity")]
        public int RelativeHumidity { get; set; }

        /// <summary>
        /// Temperature being returned.
        /// </summary>
        [JsonPropertyName("temperature")]
        public WeatherUnit Temperature { get; set; }

        [JsonPropertyName("temperatureSummary")]
        public TemperatureSummary TemperatureSummary { get; set; }

        /// <summary>
        /// Measure of the strength of the ultraviolet radiation from the sun. Supported values are:
        /// 0-2 - Low danger from the sun's UV rays or the average person.
        /// 3-5 - Moderate risk of harm from unprotected sun exposure.
        /// 6-7 - High risk of harm from unprotected sun exposure.
        /// 8-10 - Very high risk of harm from unprotected sun exposure.
        /// 11+ - Extreme risk of harm from unprotected sun exposure.
        /// </summary>
        [JsonPropertyName("uvIndex")]
        public int UvIndex { get; set; }

        /// <summary>
        /// Phrase associated with the uvIndex.
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
        /// Perceived air temperature on exposed skin due to wind.
        /// </summary>
        [JsonPropertyName("windChillTemperature")]
        public WeatherUnit WindChillTemperature { get; set; }

        /// <summary>
        /// Wind gust. Wind gust is a sudden, brief increase in speed of the wind.
        /// </summary>
        [JsonPropertyName("windGust")]
        public Wind WindGust { get; set; }


    }
}