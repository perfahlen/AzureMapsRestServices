using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// The type of the unique query parameter of the stop. By default queryType=stopId.
    /// </summary>
    public enum TransitStopQueryType : byte
    {
        /// <summary>
        /// The GTFS stop Id. GTFS stop Ids are provided by the transit authority and are subject to change.
        /// </summary>
        StopId,

        /// <summary>
        /// The unique Azure Maps identifier for the respective public transit stop. When referring stops overtime, it is suggested to use stopId that will not change if the physical stop exists.
        /// </summary>
        StopKey
    }
}
