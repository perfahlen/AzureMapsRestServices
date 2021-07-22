using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Elevation
{
    public class PostDataForPoints
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }
}
