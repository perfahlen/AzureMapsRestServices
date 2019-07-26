using AzureMapsToolkit.GeoJson;

namespace AzureMapsToolkit.Mobility
{
    public class MetroAreaResult
    {
        /// <summary>
        /// A valid GeoJSON Polygon geometry type. Please refer to RFC 7946 for details.
        /// </summary>
        public Polygon Geometry { get; set; }

        /// <summary>
        /// The metro area's Id for use with other API calls
        /// </summary>
        public int MetroId { get; set; }

        /// <summary>
        /// The main display name of the metro.
        /// </summary>
        public string MetroName { get; set; }

        /// <summary>
        /// The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport.
        /// </summary>
        public ResultViewport Viewport { get; set; }
    }
}
