using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class PressureTendency
    {
        /// <summary>
        /// Pressure tendency code regardless of language. One of F=Falling, S=Steady, R=Rising.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Description of the pressure tendency in specified language
        /// </summary>
        [JsonPropertyName("localizedDescription")]
        public string LocalizedDescription { get; set; }
    }
}