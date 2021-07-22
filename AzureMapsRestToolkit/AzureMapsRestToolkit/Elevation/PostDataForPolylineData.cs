using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Elevation
{
    public class PostDataForPolylineData
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }
}
