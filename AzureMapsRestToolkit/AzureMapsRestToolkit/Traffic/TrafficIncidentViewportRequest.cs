using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Traffic
{
    public class TrafficIncidentViewportRequest : RequestBase
    {
        /// <summary>
        /// Bounding box of the map viewport in EPSG900913 projection. The boundingbox is represented by two value pairs describing it's corners (first pair for lower left corner and second for upper right). All values should be separated by commas (e.g., minY,minX,maxY,maxX). The maximum size of the bounding box that can be passed is dependent on the requested zoom level. The width and height cannot exceed 4092 pixels when rendered on the given zoom level.
        /// NOTE: Bounding boxes that cross the 180° meridian require special treatment.For such boxes, the eastern maxX value will be negative, and thus less than the minX value west of the 180° meridian.To address that, the value 40075016.6855874 should be added to the true maxX value before it is passed in the request.
        /// </summary>
        public string Boundingbox { get; set; }

        /// <summary>
        /// Zoom level of the map viewport. Used to determine whether the view can be zoomed in.
        /// </summary>
        public int Boundingzoom { get; set; }

        /// <summary>
        /// Bounding box of the overview map in EPSG900913 projection.
        /// Used in case the overview box/mini map has different copyright data than the main map.If there is no mini map, the same coordinates as boundingBox is used.
        /// </summary>
        public string Overviewbox { get; set; }

        /// <summary>
        /// Zoom level of the overview map. If there is no mini map, use the same zoom level as boundingZoom.
        /// </summary>
        public int Overviewzoom { get; set; }


        /// <summary>
        /// Determines what copyright information to return. When true the copyright text is returned; when false only the copyright index is returned.
        /// </summary>
        public bool Copyright { get; set; }
    }
}
