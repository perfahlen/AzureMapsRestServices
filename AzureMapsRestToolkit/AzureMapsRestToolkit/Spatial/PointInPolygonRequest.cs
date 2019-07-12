using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class PointInPolygonRequest : SpatialRequestBase
    {
        /// <summary>
        /// The base point latitude of the location being passed. Example: 47.622942.
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// The base point longitude of the location being passed. Example: -122.316456.
        /// </summary>
        public double Lon { get; set; }
    }
}
