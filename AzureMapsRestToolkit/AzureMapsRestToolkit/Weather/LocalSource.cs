using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class LocalSource
    {
        /// <summary>
        /// Numeric identifier, unique to the local data provider.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the local data provider. Name is displayed in the language specified by language code in URL, if available. Otherwise, Name is displayed in English or the language in which the name was provided.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Weather code provided by the local data provider. This weather code allows the forecast to be matched to icons provided by the local data provider instead of Azure Maps icons.
        /// </summary>
        [JsonPropertyName("weatherCode")]
        public string WeatherCode { get; set; }


    }
}