
using System;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// Specify additional details requested respective to the line group as a comma separated list. As a default service returns line basic info.
    /// </summary>
    [Flags]
    public enum TransitLineDetailType : byte
    {
        AlertDetails = 1 << 0,

        Alerts = 1 << 1,

        Lines = 1 << 2,

        Patterns = 1 << 3,

        Schedule = 1 << 4,

        Stops = 1 << 5
    }
}
