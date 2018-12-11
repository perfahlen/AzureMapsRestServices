using AzureMapsToolkit.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Render
{
    public class CopyrightFromBoundingBoxRequest : RequestBase
    {

        /// <summary>
        /// Minimum coordinates of bounding box in latitude longitude coordinate system. E.g. 52.41064,4.84228
        /// </summary>
        public string Mincoordinates { get; set; }

        /// <summary>
        /// Maximum coordinates of bounding box in latitude longitude coordinate system. E.g. 52.41064,4.84228
        /// </summary>
        public string Maxcoordinates { get; set; }

        /// <summary>
        /// Yes/no value to exclude textual data from response. Only images and country names will be in response.
        /// </summary>
        public string Text { get; set; } = "yes";
    }
}
