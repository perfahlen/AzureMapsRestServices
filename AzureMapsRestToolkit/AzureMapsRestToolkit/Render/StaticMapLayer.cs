using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Render
{
    /// <summary>
    /// Map layer requested. If layer is set to labels or hybrid, the format should be png.
    /// </summary>
    public enum StaticMapLayer
    {
        /// <summary>
        /// Returns an image containing all map features including polygons, borders, roads and labels.
        /// </summary>
        basic,

        /// <summary>
        /// Returns an image containing borders, roads, and labels, and can be overlaid on other tiles (such as satellite imagery) to produce hybrid tiles.
        /// </summary>
        hybrid,

        /// <summary>
        /// Returns an image of just the map's label information.
        /// </summary>
        labels
    }
}
