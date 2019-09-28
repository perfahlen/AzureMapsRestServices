using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// Specify additional details requested respective to the transit stop as a commma separated list.
    /// </summary>
    [Flags]
    public enum TransitStopDetailType : byte
    {
        /// <summary>
        /// Can only be used in conjunction with detailType=alerts.Return additional details associated with the active service alerts.
        /// </summary>
        AlertDetails,

        /// <summary>
        /// Return any active service alerts for the specified stop. Response provides brief information for disruption in service and all basic data associated with the alert.
        /// </summary>
        Alerts,

        /// <summary>
        /// Return line groups that stops at the specified stop.
        /// </summary>
        LineGroups,

        /// <summary>
        /// Return transit lines that stops at the specified stop.
        /// </summary>
        Lines
    }
}
