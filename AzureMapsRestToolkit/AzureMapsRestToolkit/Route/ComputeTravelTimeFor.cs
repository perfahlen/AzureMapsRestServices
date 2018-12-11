namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Specifies whether to return additional travel times using different types of traffic information (none, historic, live) as well as the default best-estimate travel time.
    /// </summary>
    public enum ComputeTravelTimeFor
    {
        /// <summary>
        /// Computes travel times for all types of traffic information and specifies all results in the fields noTrafficTravelTimeInSeconds, historicTrafficTravelTimeInSeconds and liveTrafficIncidentsTravelTimeInSeconds being included in the summaries in the route response.
        /// </summary>
        all,

        /// <summary>
        /// Does not compute additional travel times.
        /// </summary>
        none
    }
}
