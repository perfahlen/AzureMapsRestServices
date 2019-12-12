using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Render
{
    public class MapImageryTileRequest : RequestBase
    {

        /// <summary>
        /// Desired format of the response. Possible value: png.
        /// </summary>
        public RasterTileFormat Format { get; set; }

        /// <summary>
        /// Zoom level for the desired tile. Zoom value must be in the range: 1-19 (inclusive). Please see Zoom Levels and Tile Grid for details.
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
        /// Map style to be returned. Possible values: satellite.
        /// </summary>
        public MapImageryStyle Style { get; set; } = MapImageryStyle.satellite;
    }
}
