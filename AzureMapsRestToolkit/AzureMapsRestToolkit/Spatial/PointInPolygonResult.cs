using Newtonsoft.Json;

namespace AzureMapsToolkit.Spatial
{
    public class PointInPolygonResult
    {
        /// <summary>
        /// Geometries array
        /// </summary>
        [JsonProperty("intersectingGeometries")]
        public string[] IntersectingGeometries { get; set; }

        /// <summary>
        /// Point In Polygons Property
        /// </summary>
        [JsonProperty("pointInPolygons")]
        public bool PointInPolygons { get; set; }
    }
}