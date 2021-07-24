using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class DayOrNight
    {
        /// <summary>
        /// Percent representing cloud cover.
        /// </summary>
        [JsonPropertyName("cloudCover")]
        public int CloudCover { get; set; }

        /// <summary>
        /// Indicates the presence or absence of precipitation. True indicates the presence of precipitation, false indicates the absence of precipitation.
        /// </summary>
        [JsonPropertyName("hasPrecipitation")]
        public bool HasPrecipitation { get; set; }

        /// <summary>
        /// Hours of ice.
        /// </summary>
        [JsonPropertyName("hoursOfIce")]
        public double HoursOfIce { get; set; }

        /// <summary>
        /// Hours of precipitation
        /// </summary>
        [JsonPropertyName("hoursOfPrecipitation")]
        public double HoursOfPrecipitation { get; set; }

        /// <summary>
        /// Hours of rain.
        /// </summary>
        [JsonPropertyName("hoursOfRain")]
        public double HoursOfRain { get; set; }

        /// <summary>
        /// Hours of snow.
        /// </summary>
        [JsonPropertyName("hoursOfSnow")]
        public double HoursOfSnow { get; set; }

        /// <summary>
        /// Ice
        /// </summary>
        [JsonPropertyName("ice")]
        public WeatherUnit Ice { get; set; }

        /// <summary>
        /// Percent representing the probability of ice. For example, '30'.
        /// </summary>
        [JsonPropertyName("iceProbability")]
        public int IceProbability { get; set; }

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
        /// 
        /// </summary>
        [JsonPropertyName("localSource")]
        public LocalSource LocalSource { get; set; }

        /// <summary>
        /// Phrase description of the forecast in specified language. Azure Maps attempts to keep this phrase under 100 characters in length, but some languages/weather events may result in a longer phrase length, exceeding 100 characters.
        /// </summary>
        [JsonPropertyName("longPhrase")]
        public string LongPhrase { get; set; }

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
        /// Rain
        /// </summary>
        [JsonPropertyName("rain")]
        public WeatherUnit Rain { get; set; }

        /// <summary>
        /// Percent representing the probability of rain. For example, '40'.
        /// </summary>
        [JsonPropertyName("rainProbability")]
        public int RainProbability { get; set; }

        /// <summary>
        /// Phrase description of the forecast in specified language. Azure Maps attempts to keep this phrase under 30 characters in length, but some languages/weather events may result in a longer phrase length, exceeding 30 characters.
        /// </summary>
        [JsonPropertyName("shortPhrase")]
        public string ShortPhrase { get; set; }

        /// <summary>
        /// Snow
        /// </summary>
        [JsonPropertyName("snow")]
        public WeatherUnit Snow { get; set; }

        /// <summary>
        /// Percent representing the probability of snow. For example, '30'.
        /// </summary>
        [JsonPropertyName("snowProbability")]
        public int SnowProbability { get; set; }

        /// <summary>
        /// Percent representing the probability of a thunderstorm. For example, '80'.
        /// </summary>
        [JsonPropertyName("thunderstormProbability")]
        public int ThunderstormProbability { get; set; }

        /// <summary>
        /// Total liquid equivalent of precipitation during the forecast period.
        /// </summary>
        [JsonPropertyName("totalLiquid")]
        public WeatherUnit TotalLiquid { get; set; }

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