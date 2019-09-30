using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// Specifies whether the time signifies departure time or arrival time. If not defined, default value is 'departure'.
    /// </summary>
    public enum TimeType
    {
        /// <summary>
        /// arrival at the destination point. Requires that 'time' value must be in the future.
        /// </summary>
        [NameArgument("arrival")]
        Arrival,

        /// <summary>
        /// 
        /// </summary>
        [NameArgument("departure")]
        Departure,

        /// <summary>
        /// Request the last lines for the day.
        /// </summary>
        [NameArgument("last")]
        Last

    }
}