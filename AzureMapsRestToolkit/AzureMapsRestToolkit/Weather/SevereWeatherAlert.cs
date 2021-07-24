using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class SevereWeatherAlert
    {
        /// <summary>
        /// Information about the alert specific to the affected area(s).
        /// </summary>
        [JsonPropertyName("alertAreas")]
        public AlertArea[] AlertAreas { get; set; }

        /// <summary>
        /// A unique numerical identifier for a weather alert.
        /// </summary>
        [JsonPropertyName("alertId")]
        public int AlertId { get; set; }

        /// <summary>
        /// Category of the alert.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Classification of the alert. This field is not available for all countries and therefore not always returned.
        /// </summary>
        [JsonPropertyName("class")]
        public string Class { get; set; }

        /// <summary>
        /// "2-character ISO 3166-1 Alpha-2 country code, for example, ""US""."
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Description of the alert.
        /// </summary>
        [JsonPropertyName("description")]
        public Description Description { get; set; }

        /// <summary>
        /// A disclaimer regarding the source of the alert information. This field is not always available. For example, disclaimer may include details about the delays or potential issues related to the alarm.
        /// </summary>
        [JsonPropertyName("disclaimer")]
        public string Disclaimer { get; set; }

        /// <summary>
        /// Severity level of the alert. This field is not available for all countries and therefore not always returned.
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// Number signifying the importance or ranking order of the given alert within the country/region it has originated. A lower number signifies a higher priority. For example, 1 is the highest priority. The number varies by country/region and can change over time as each country/region evolves their alert systems.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// The provider of the alert information. By default the source is returned in English (en-US). The alerts are from official Government Meteorological Agencies and leading global weather alert providers.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// A numerical identifier associated with the source provider name of the alert data.
        /// </summary>
        [JsonPropertyName("sourceId")]
        public int SourceId { get; set; }


    }
}