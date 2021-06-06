using System.Text.Json;
using System.Text.Json.Serialization;

using AzureMapsToolkit.Traffic;

namespace AzureMapsToolkit.GeoJson
{
    public class LineString
    {
        [JsonPropertyName("type")]
        public string Type { get { return "LineString"; } }

        [JsonPropertyName("coordinates")]
        public Coordinates Coordinates { get; set; }



    }
}
