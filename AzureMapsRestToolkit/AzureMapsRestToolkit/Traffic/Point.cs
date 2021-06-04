using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Traffic
{
    public class Point
    {
        /// <summary>
        /// x coordinate
        /// </summary>
        [JsonPropertyName("x")]
        public double X { get; set; }

        /// <summary>
        /// y coordinate
        /// </summary>
        [JsonPropertyName("y")]
        public double Y { get; set; }
    }
}
