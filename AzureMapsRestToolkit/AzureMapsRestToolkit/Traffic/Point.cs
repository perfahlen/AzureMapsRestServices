using Newtonsoft.Json;

namespace AzureMapsToolkit.Traffic
{
    public class Point
    {
        /// <summary>
        /// x coordinate
        /// </summary>
        [JsonProperty("x")]
        public double X { get; set; }

        /// <summary>
        /// y coordinate
        /// </summary>
        [JsonProperty("y")]
        public double Y { get; set; }
    }
}
