using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Elevation
{
    public class GetElevationDataForBoundingBoxRequest : RequestBase
    {
        /// <summary>
        /// The string that represents the rectangular area of a bounding box. The bounds parameter is defined by the 4 bounding box coordinates, with WGS84 longitude and latitude of the southwest corner followed by WGS84 longitude and latitude of the northeast corner. The string is presented in the following format: [SouthwestCorner_Longitude, SouthwestCorner_Latitude, NortheastCorner_Longitude, NortheastCorner_Latitude]. For example Bounds="-121.66853362143818, 46.84646479863713,-121.65853362143818"
        /// </summary>
        public string Bounds { get; set; }

        /// <summary>
        /// Specifies the number of columns to use to divide the bounding box area into a grid. The number of vertices in the grid should be less than 2,000.
        /// </summary>
        public short Columns { get; set; }

        /// <summary>
        /// Specifies the number of rows to use to divide the bounding box area into a grid. The number of vertices in the grid should be less than 2,000.
        /// </summary>
        public short Rows { get; set; }
    }
}
