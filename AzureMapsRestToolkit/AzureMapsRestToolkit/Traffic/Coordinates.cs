using AzureMapsToolkit.Common;
using Newtonsoft.Json;

namespace AzureMapsToolkit.Traffic
{
    public class Coordinates
    {
        [JsonProperty("coordinate")]
        public Coordinate[] Coordinate { get; set; }
    }
}