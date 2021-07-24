using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class Waypoint
    {

        /// <summary>
        /// Percent representing cloud cover.
        /// </summary>
        [JsonPropertyName("cloudCover")]
        public int CloudCover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("hazards")]
        public Hazards Hazards { get; set; }

        /// <summary>
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        /// <summary>
        /// Indicates the time of the day. True indicates 'day',', false indicates 'night.
        /// </summary>
        [JsonPropertyName("isDayTime")]
        public bool IsDayTime { get; set; }

        /// <summary>
        ///  values of 1 and higher mean there is a thunderstorm in increasing intensity."
        /// </summary>
        [JsonPropertyName("lightningCount")]
        public int LightningCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("notifications")]
        public Notification[] Notifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("precipitation")]
        public WeatherAlongRoutePrecipitation Precipitation { get; set; }

        /// <summary>
        /// A displayable short phrase describing the forecasted conditions and precipitation intensity/type.
        /// </summary>
        [JsonPropertyName("shortPhrase")]
        public string ShortPhrase { get; set; }

        /// <summary>
        /// A rating that indicates how blinding the sun is for the driver.
        /// </summary>
        [JsonPropertyName("sunGlare")]
        public SunGlare SunGlare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("temperature")]
        public WeatherUnit Temperature { get; set; }

        /// <summary>
        /// Wind details being returned including speed and direction.
        /// </summary>
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// Wind details being returned including speed and direction.
        /// </summary>
        [JsonPropertyName("windGust")]
        public Wind WindGust { get; set; }


    }
}