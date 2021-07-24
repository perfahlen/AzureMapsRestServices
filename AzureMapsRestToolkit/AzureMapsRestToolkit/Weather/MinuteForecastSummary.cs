using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class MinuteForecastSummary
    {
        /// <summary>
        /// Summary phrase for the next 120 minutes. Phrase length is approximately 60 characters.
        /// </summary>
        [JsonPropertyName("briefPhrase")]
        public string BriefPhrase { get; set; }

        /// <summary>
        /// Summary phrase for the next 60 minutes. Phrase length is approximately 60 characters.
        /// </summary>
        [JsonPropertyName("briefPhrase60")]
        public string BriefPhrase60 { get; set; }

        /// <summary>
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        /// <summary>
        /// Long summary phrase for the next 120 minutes. Phrase length is 60+ characters.
        /// </summary>
        [JsonPropertyName("longPhrase")]
        public string LongPhrase { get; set; }

        /// <summary>
        /// Short summary phrase for the next 120 minutes. Phrase length is approximately 25 characters.
        /// </summary>
        [JsonPropertyName("shortPhrase")]
        public string ShortPhrase { get; set; }


    }
}