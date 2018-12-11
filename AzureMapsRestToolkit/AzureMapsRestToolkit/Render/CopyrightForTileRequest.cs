using AzureMapsToolkit.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Render
{
    public class CopyrightForTileRequest : RequestBase
    {
        // int zoom, int x, int y, string text = "yes"


        /// <summary>
        /// 	Zoom level for the desired tile.Zoom value must be in the range: 0-18 (inclusive).
        /// </summary>
        public int Zoom { get; set; }

        /// <summary>
        /// X coordinate of the tile on zoom grid. Value must be in the range [0, 2 zoom -1].
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate of the tile on zoom grid. Value must be in the range [0, 2 zoom -1].
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Yes/no value to exclude textual data from response.Only images and country names will be in response.
        /// </summary>
        public string Text { get; set; } = "yes";
    }
}
