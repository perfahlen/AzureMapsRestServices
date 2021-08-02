using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Weather
{
    public class Quarter
    {

        [JsonPropertyName("0")]
        public string _0 { get; set; }

        [JsonPropertyName("1")]
        public string _1 { get; set; }

        [JsonPropertyName("2")]
        public string _2 { get; set; }

        [JsonPropertyName("3")]
        public string _3 { get; set; }

    }
}

