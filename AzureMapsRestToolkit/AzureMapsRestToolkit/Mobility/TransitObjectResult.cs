using AzureMapsToolkit.Common;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    public class TransitObjectResult
    {
        /// <summary>
        /// The object identifier found as a result of the query, for example, stopId for stops.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The object specific details.
        /// </summary>
        [JsonPropertyName("objectDetails")]
        public object ObjectDetails { get; set; }

        /// <summary>
        /// The transit object's position.
        /// </summary>
        [JsonPropertyName("position")]
        public Coordinate Position { get; set; }

        /// <summary>
        /// The type of object found as a result of the query.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport.
        /// </summary>
        [JsonPropertyName("viewport")]
        public ResultViewport Viewport { get; set; }
    }
}