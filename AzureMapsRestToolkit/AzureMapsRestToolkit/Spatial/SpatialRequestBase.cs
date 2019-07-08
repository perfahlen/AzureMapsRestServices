using AzureMapsToolkit.Common;
using System;

namespace AzureMapsToolkit.Spatial
{
    public class SpatialRequestBase : RequestBase
    {
        /// <summary>
        /// The unique id returned from Data Upload API after uploading a valid GeoJSON FeatureCollection object. Please refer to RFC 7946 for details. All the feature's properties should contain geometryId, which is used for identifying the geometry and is case-sensitive.
        /// </summary>
        public Guid Udid { get; set; }

    }
}
