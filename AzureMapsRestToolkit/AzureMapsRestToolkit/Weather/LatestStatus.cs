using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class LatestStatus
    {
        /// <summary>
        /// The latest status keyword for the alert, in the specified language. By default, returned in English (en-US).
        /// </summary>
        [JsonPropertyName("localized")]
        public string Localized { get; set; }

        /// <summary>
        /// Latest status keyword for the alert, in English (en-US)
        /// </summary>
        [JsonPropertyName("english")]
        public string English { get; set; }
    }
}