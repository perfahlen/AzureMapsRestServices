using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Elevation
{
    public class BoundingBoxResult
    {
        [JsonPropertyName("data")]
        public PointElevationResult[] Result { get; set; }
    }
}
