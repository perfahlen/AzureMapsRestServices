using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Spatial
{
    public class PointInPolygonResult
    {
        /// <summary>
        /// Geometries array
        /// </summary>
        [JsonPropertyName("intersectingGeometries")]
        public string[] IntersectingGeometries { get; set; }

        /// <summary>
        /// Point In Polygons Property
        /// </summary>
        [JsonPropertyName("pointInPolygons")]
        public bool PointInPolygons { get; set; }
    }
}