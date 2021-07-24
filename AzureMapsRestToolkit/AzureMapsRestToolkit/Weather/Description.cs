using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class Description
    {
        /// <summary>
        /// Description of the alert in English (en-US).
        /// </summary>
        [JsonPropertyName("english")]
        public string English { get; set; }

        /// <summary>
        /// Description of the alert in the specified language. By default English (en-US) is returned if the language parameter is not specified in the request.
        /// </summary>
        [JsonPropertyName("localized")]
        public string Localized { get; set; }
    }
}