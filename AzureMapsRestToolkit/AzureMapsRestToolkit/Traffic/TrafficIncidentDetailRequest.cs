using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Traffic
{
    public class TrafficIncidentDetailRequest : RequestBase
    {
        /// <summary>
        /// The style that will be used to render the tile in Traffic Incident Tile API. This will have an effect on the coordinates of traffic incidents in the reply.
        /// </summary>
        public TrafficIncidentTileStyle Style { get; set; }

        /// <summary>
        /// The boundingbox is represented by two value pairs describing it's corners (first pair for lower left corner and second for upper right). The pairs can either be specified using any of the projection's specified below (e.g., minY,minX,maxY,maxX) or by two latitude-longitude pairs (e.g., minLat,minLon,maxLat,maxLon).
        /// NOTE: If latitude/longitude pairs are used, then the projection parameter must be set to "EPSG4326".
        /// </summary>
        public string Boundingbox { get; set; }

        /// <summary>
        /// Zoom level for desired tile. 0 to 18 for raster tiles, 0 through 20 for vector tiles
        /// </summary>
        public int? BoundingZoom { get; set; }

        /// <summary>
        /// Number referencing traffic model. This can be obtained from the Viewport API. It is updated every minute, and is valid for two minutes before it times out. If the wrong Traffic Model ID is specified, the correct one will be returned by the interface. A value of -1 will always invoke the most recent traffic model
        /// </summary>
        public string Trafficmodelid { get; set; }


        /// <summary>
        /// ISO 639-1 code for the output language. Supported languages are ar, ca, cs, da, de, el, en, en-GB, en-US, es, et, fi, fr, he, hu, id, in*, it, lt, lv, nb, nl, no, pl, pt, ro, ru, sk, sv, th, tr, zh
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// The projection used to specify the coordinates in the request and response. EPSG900913 (default) or EPSG4326
        /// </summary>
        public string Projection { get; set; }

        /// <summary>
        /// The type of vector geometry added to incidents (returned in the element of the response).
        /// </summary>
        public IncidentGeometryType Geometries { get; set; }

        /// <summary>
        /// Boolean to indicate whether to list all traffic incidents in a cluster separately
        /// </summary>
        public bool? ExpandCluster { get; set; }

        /// <summary>
        /// Boolean on whether to return the original position of the incident() as well as the one shifted to the beginning of the traffic tube()
        /// </summary>
        public bool? OriginalPosition { get; set; }
    }
}
