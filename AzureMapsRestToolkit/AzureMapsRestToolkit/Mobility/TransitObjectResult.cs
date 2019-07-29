using AzureMapsToolkit.Common;
using Newtonsoft.Json;

namespace AzureMapsToolkit.Mobility
{
    public class TransitObjectResult
    {
        /// <summary>
        /// The object identifier found as a result of the query, for example, stopId for stops.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The object specific details.
        /// </summary>
        [JsonProperty("objectDetails")]
        public object ObjectDetails { get; set; }

        /// <summary>
        /// The transit object's position.
        /// </summary>
        [JsonProperty("position")]
        public Coordinate Position { get; set; }

        /// <summary>
        /// The type of object found as a result of the query.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport.
        /// </summary>
        [JsonProperty("viewport")]
        public ResultViewport Viewport { get; set; }
    }
}