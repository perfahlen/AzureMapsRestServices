using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class DailyForecastSummary
    {
        /// <summary>
        /// one or 2 word(s) to summarize the phrase
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Date and time that the summary period ends, displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// Summary phrase of the daily forecast. Displayed in specified language.
        /// </summary>
        [JsonPropertyName("phrase")]
        public string Phrase { get; set; }

        /// <summary>
        /// severity
        /// </summary>
        [JsonPropertyName("severity")]
        public int Severity { get; set; }


        /// <summary>
        /// Date and time that the summary is in effect, displayed in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00.
        /// </summary>
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }


    }
}