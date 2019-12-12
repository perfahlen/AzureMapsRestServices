using AzureMapsToolkit.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Render
{
    public class MapImageRequest : RequestBase
    {
        //RasterTileFormat format, MapLayer layer, string bbox, string center,
        //    int zoom = 12, int height = 512, int width = 512, string language = "en", string style = "main"

        /// <summary>
        /// Desired format of the response. Possible value: png.
        /// </summary>
        public RasterTileFormat Format { get; set; }

        /// <summarMap
        /// Map style to be returned. Currently, only style available is main.
        /// </summary>
        public StaticMapLayer Layer { get; set; }

        /// <summary>
        /// Bounding box. Projection used - EPSG:3857. Format : 'minLon, minLat, maxLon, maxLat'. Note: Either bbox or center are required parameters. They are mutually exclusive. It shouldn’t be used with height or width. The maximum allowed ranges for Lat and Lon are defined for each zoom level in the table at the top of this page.
        /// </summary>
        public string Bbox { get; set; }

        /// <summary>
        /// Coordinates of the center point. Format: 'lon,lat'. Projection used - EPSG:3857. Longitude range: -180 to 180. Latitude range: -85 to 85. Note: Either center or bbox are required parameters. They are mutually exclusive.
        /// </summary>
        public string Center { get; set; }

        /// <summary>
        /// Desired zoom level of the map. Zoom value must be in the range: 0-20 (inclusive). Default value is 12.
        /// </summary>
        public int? Zoom { get; set; } = 12;

        /// <summary>
        /// Height of the resulting image in pixels. Range is 1 to 8192. Default is 512. It shouldn’t be used with bbox.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Width of the resulting image in pixels. Range is 1 to 8192. Default is 512. It shouldn’t be used with bbox.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used.
        /// </summary>
        public string Language { get; set; } = "en";

        /// <summary>
        /// Map style to be returned. Currently, only style available is main.
        /// </summary>
        public string Style { get; } = "main";

    }
}
