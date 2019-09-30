using AzureMapsToolkit.Common;
using System;

namespace AzureMapsToolkit.Spatial
{
    public class BufferRequest : SpatialRequestBase
    {
   
        /// <summary>
        /// The list of distances (one per feature or one for all features), delimited by semicolons. For example, 12.34;-56.78. Positive distance will generate a buffer outside of the feature, whereas negative distance will generate a buffer inside of the feature. If the negative distance larger than the geometry itself, an empty polygon will be returned.
        /// </summary>
        public string Distances { get; set; }
    }
}
