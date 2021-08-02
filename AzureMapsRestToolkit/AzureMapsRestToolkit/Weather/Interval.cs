using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class Interval
    {
        /// <summary>
        /// Percent representing cloud cover.
        /// </summary>
        [JsonPropertyName("cloudCover")]
        public int CloudCover { get; set; }

        /// <summary>
        /// The full spectrum color that maps to the dBZ (decibel relative to Z). If dbz is zero, color is not present in the response.
        /// </summary>
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        /// <summary>
        /// A unit that represents forecasted precipitation intensity.
        /// </summary>
        [JsonPropertyName("dbz")]
        public double Dbz { get; set; }

        /// <summary>
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        /// <summary>
        /// The first minute for the interval.
        /// </summary>
        [JsonPropertyName("minute")]
        public int Minute { get; set; }

        /// <summary>
        /// "Specifies the type of precipitation (""rain"" ""snow"" ""ice"" or ""mix""). If dbz is zero, precipitationType is not present in the response."
        /// </summary>
        [JsonPropertyName("precipitationType")]
        public string PrecipitationType { get; set; }

        /// <summary>
        /// A short phrase describing precipitation condition for the interval.
        /// </summary>
        [JsonPropertyName("shortPhrase")]
        public string ShortPhrase { get; set; }

        /// <summary>
        /// The band color that maps to the precipitation type and threshold. If dbz is zero, not present in the response.
        /// </summary>
        [JsonPropertyName("simplifiedColor")]
        public Color SimplifiedColor { get; set; }

        /// <summary>
        /// The date and time for the start of the interval in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Key that specifies the threshold value. Along with precipitationType, can be used to determine the simplifiedColor. If dbz is zero, not present in the response.
        /// </summary>
        [JsonPropertyName("threshold")]
        public string Threshold { get; set; }


    }
}