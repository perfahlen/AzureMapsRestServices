using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.GeoJson
{
    public class LineString
    {
        [JsonPropertyName("type")]
        public string Type { get { return "LineString"; } }

        [JsonPropertyName("coordinates")]
        public double[,] Coordinates { get; set; }



    }
}
