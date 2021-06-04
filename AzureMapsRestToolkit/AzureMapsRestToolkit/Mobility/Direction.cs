using System.Text.Json;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Mobility
{
    public class Direction
    {
        [JsonConverter(typeof (JsonStringEnumConverter))]
        public AbsoluteDirection AbsoluteDirection { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RelativeDirection RelativeDirection { get; set; }
    }
}
