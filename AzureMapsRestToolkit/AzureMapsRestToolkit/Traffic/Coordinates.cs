using AzureMapsToolkit.Common;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    public class Coordinates
    {
        [JsonPropertyName("coordinate")]
        public Coordinate[] Coordinate { get; set; }
    }
}