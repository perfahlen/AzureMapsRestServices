using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class TemperatureSummary
    {
        [JsonPropertyName("past12Hours")]
        public PastHours Past12Hours { get; set; }

        [JsonPropertyName("past24Hours")]
        public PastHours Past24Hours { get; set; }

        [JsonPropertyName("past6Hours")]
        public PastHours Past6Hours { get; set; }



    }
}