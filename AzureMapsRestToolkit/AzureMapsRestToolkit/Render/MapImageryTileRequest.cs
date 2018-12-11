using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Render
{
    public class MapImageryTileRequest : RequestBase
    {

        public RasterTileFormat Format { get; set; }

        public int Zoom { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public MapImageryStyle Style { get; set; } = MapImageryStyle.satellite;
    }
}
