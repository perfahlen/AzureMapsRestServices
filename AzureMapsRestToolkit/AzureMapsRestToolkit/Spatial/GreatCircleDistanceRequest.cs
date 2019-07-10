using AzureMapsToolkit.Common;
using System.Collections.Generic;

namespace AzureMapsToolkit.Spatial
{
    public class GreatCircleDistanceRequest : RequestBase
    {
        /// <summary>
        /// The Coordinates through which the distance is calculated, delimited by a colon. Two coordinates are required. The first one is the source point coordinate and the last is the target point coordinate. For example, 47.622942,122.316456:57.673988,127.121513
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Instead of setting Query in raw format it is possible to set Start AND End and add Vias, the proxy will build a Query for Azure Maps
        /// </summary>
        public Coordinate Start { get; set; }

        /// <summary>
        /// Instead of setting Query in raw format it is possible to set Start AND End and add Vias, the proxy will build a Query for Azure Maps
        /// </summary>
        public Coordinate End { get; set; }

    }
}