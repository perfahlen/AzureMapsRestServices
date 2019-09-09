using System;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// The mode of travel for the requested route; as comma separated list. If not specified, all modes will be allowed. All modes might not be available in all metro areas. If valid trip is not found, empty result will be returned.
    /// </summary>
    [Flags]
    public enum ModeType : byte
    {
        /// <summary>
        /// bike
        /// </summary>
        Bike = 1 << 0,

        /// <summary>
        /// Public transit
        /// </summary>
        PublicTransit = 1 << 1,

        /// <summary>
        /// Walk (pedestrian)
        /// </summary>
        Walk = 1 << 2
    }
}