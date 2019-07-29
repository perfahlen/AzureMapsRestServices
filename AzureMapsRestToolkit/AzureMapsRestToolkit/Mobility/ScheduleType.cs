namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// Whether the result is based on real-time or static data.
    /// </summary>
    public enum ScheduleType
    {
        /// <summary>
        /// Returned when estimated time of arrival is based on static data.
        /// </summary>
        RealTime,

        /// <summary>
        /// Returned when estimated time of arrival is based on real-time data.
        /// </summary>
        ScheduledTime
    }
}