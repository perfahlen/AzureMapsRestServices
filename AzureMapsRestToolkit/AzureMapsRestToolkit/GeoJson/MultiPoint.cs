using Newtonsoft.Json;

namespace AzureMapsToolkit.GeoJson
{
    public class MultiPoint
    {
        [JsonProperty("coordinates")]
        public double[,] Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get { return "MultiPoint"; } }
    }
}
