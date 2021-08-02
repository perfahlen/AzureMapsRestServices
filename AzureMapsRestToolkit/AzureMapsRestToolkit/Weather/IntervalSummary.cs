using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class IntervalSummary
    {
        /// <summary>
        /// Brief summary phrase. Phrase length is approximately 60 characters.
        /// </summary>
        [JsonPropertyName("briefPhrase")]
        public string BriefPhrase { get; set; }

        /// <summary>
        /// The last minute to which the summary applies.
        /// </summary>
        [JsonPropertyName("endMinute")]
        public int EndMinute { get; set; }

        /// <summary>
        /// Numeric value representing an image that displays the iconPhrase. Please refer to Weather Service Concepts for details.
        /// </summary>
        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        /// <summary>
        /// Long summary phrase. Phrase length is 60+ characters.
        /// </summary>
        [JsonPropertyName("longPhrase")]
        public string LongPhrase { get; set; }

        /// <summary>
        /// Short summary phrase. Phrase length is approximately 25 characters.
        /// </summary>
        [JsonPropertyName("shortPhrase")]
        public string ShortPhrase { get; set; }

        /// <summary>
        /// The first minute to which the summary applies.
        /// </summary>
        [JsonPropertyName("startMinute")]
        public int StartMinute { get; set; }

        /// <summary>
        /// The number of minutes for which the summary applies.
        /// </summary>
        [JsonPropertyName("totalMinutes")]
        public int TotalMinutes { get; set; }


    }
}