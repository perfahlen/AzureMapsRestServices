using Newtonsoft.Json;

namespace AzureMapsToolkit.GeoJson
{
    public class LineString
    {
        [JsonProperty("type")]
        public string Type { get { return "LineString"; } }

        [JsonProperty("coordinates")]
        public double[,] Coordinates { get; set; }



    }
}
