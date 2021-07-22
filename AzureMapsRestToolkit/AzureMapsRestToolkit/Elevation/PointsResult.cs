using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Elevation
{
    public class PointsResult
    {
        [JsonPropertyName("data")]
        public PointElevationResult[] PointsElevationResult { get; set; }
    }
}
