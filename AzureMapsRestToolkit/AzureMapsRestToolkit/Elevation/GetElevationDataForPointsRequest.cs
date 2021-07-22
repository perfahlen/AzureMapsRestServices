using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Elevation
{
    public class GetElevationDataForPointsRequest : RequestBase
    {
        /// <summary>
        /// The string representation of a list of points. A point is defined in lat/lon WGS84 coordinate reference system format. If multiple points are requested, each of the points in a list should be separated by the pipe ('|') character. The maximum number of points that can be requested in a single request is 2,000. The resolution of the elevation data will be the highest for a single point and will decrease if multiple points are spread further apart. For example -121.66853362143818, 46.84646479863713|-121.68853362143818, 46.856464798637127
        /// </summary>
        public string Points { get; set; }
    }
}
