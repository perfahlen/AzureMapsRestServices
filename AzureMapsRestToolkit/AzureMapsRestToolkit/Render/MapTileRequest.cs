using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Render
{
    public class MapTileRequest : RequestBase
    {

        /// <summary>
        /// Desired format of the response. Possible values are png & pbf.
        /// </summary>
        public TileFormat Format { get; set; }

        /// <summary>
        /// Map layer requested. Possible values are basic, hybrid and labels.
        /// </summary>
        public StaticMapLayer Layer { get; set; }

        /// <summary>
        /// Zoom level for the desired tile. For raster tiles, value must be in the range: 0-18 (inclusive). For vector tiles, value must be in the range: 0-20 (inclusive).
        /// </summary>
        public int Zoom { get; set; }

        /// <summary>
        /// X coordinate of the tile on zoom grid. Value must be in the range [0, 2zoom -1].
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate of the tile on zoom grid. Value must be in the range [0, 2zoom -1].
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// The size of the returned map tile in pixels.
        /// </summary>
        public MapTileSize TileSize { get; set; } = MapTileSize._256;

        /// <summary>
        /// Language in which search results should be returned. Should be one of supported IETF language tags, case insensitive. When data in specified language is not available for a specific field, default language is used.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Map style to be returned. Currently there is only one style, e.g. main.
        /// </summary>
        public MapTileStyle Style { get; set; } = MapTileStyle.main;


    }
}
