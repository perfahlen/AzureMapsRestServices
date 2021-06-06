using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.GeoJson
{
    public class MultiPoint
    {
        [JsonPropertyName("coordinates")]
        public double[,] Coordinates { get; set; }

        [JsonPropertyName("type")]
        public string Type { get { return "MultiPoint"; } }
    }
}
