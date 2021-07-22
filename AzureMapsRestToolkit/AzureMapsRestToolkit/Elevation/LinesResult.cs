using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Elevation
{
    public class LinesResult
    {
        [JsonPropertyName("data")]
        public PointElevationResult[] Result { get; set; }
    }
}
