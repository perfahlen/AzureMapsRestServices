using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AzureMapsToolkit.Mobility
{
    public class Direction
    {
        [JsonConverter(typeof (StringEnumConverter))]
        public AbsoluteDirection AbsoluteDirection { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RelativeDirection RelativeDirection { get; set; }
    }
}
