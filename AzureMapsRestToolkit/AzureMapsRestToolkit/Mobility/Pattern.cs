using AzureMapsToolkit.GeoJson;

namespace AzureMapsToolkit.Mobility
{
    public class Pattern
    {
        /// <summary>
        /// Stop sequence and shape per a line in GeoJSON format.
        /// </summary>
        public LineString Geometry { get; set; }

        /// <summary>
        /// Line Id.
        /// </summary>
        public string LineId { get; set; }

        /// <summary>
        /// Pattern Id, for example, '3267995'.
        /// </summary>
        public string PatternId { get; set; }

        /// <summary>
        /// Stops the line goes through.
        /// </summary>
        public string[] StopIds { get; set; }
    }
}