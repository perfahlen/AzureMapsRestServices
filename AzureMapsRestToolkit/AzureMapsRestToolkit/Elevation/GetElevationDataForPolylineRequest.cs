using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Elevation
{
    public class GetElevationDataForPolylineRequest : RequestBase
    {
        /// <summary>
        /// The string representation of a polyline path. A polyline is defined by endpoint coordinates, with each endpoint separated by a pipe ('|') character. The polyline should be defined in the following format: [longitude_point1, latitude_point1 | longitude_point2, latitude_point2, ..., longitude_pointN, latitude_pointN].
        /// The longitude and latitude values refer to the World Geodetic System(WGS84) coordinate reference system.The resolution of the data used to compute the elevation depends on the distance between the endpoints.
        /// 
        /// </summary>
        public string Lines { get; set; }

        /// <summary>
        /// The samples parameter specifies the number of equally spaced points at which elevation values should be provided along a polyline path. The number of samples should range from 2 to 2,000. Default value is 10.
        /// </summary>
        public int? Samples { get; set; }
    }
}
