using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Spatial
{
    public class ClosestPointRequest: SpatialRequestBase
    {
        /// <summary>
        /// The base point latitude of the location being passed. Example: 47.622942.
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// The base point longitude of the location being passed. Example: -122.316456.
        /// </summary>
        public double Lon { get; set; }

        /// <summary>
        /// The number of closest points expected from response. Default: 1, minimum: 1 and maximum: 50
        /// </summary>
        public int? NumberOfClosestPoints { get; set; }
    }
}