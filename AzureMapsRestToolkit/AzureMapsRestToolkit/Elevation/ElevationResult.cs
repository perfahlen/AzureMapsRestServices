using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Elevation
{
    public class ElevationResult
    {
        [JsonPropertyName("data")]
        public PointElevationResult[] Result { get; set; }
    }
}
