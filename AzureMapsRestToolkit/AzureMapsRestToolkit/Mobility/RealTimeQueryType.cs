namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// The type of the query parameter. Defines the mode of the request. Only one mode per request is supported. By default queryType is set to be ‘stops’ returning the requested number of Live Arrivals for all lines arriving at the specified stop.
    /// </summary>
    public enum RealTimeQueryType
    {

        /// <summary>
        /// One or multiple stops as a comma separated list. Returns the requested number of live arrivals for all lines arriving at the specified stop. Defined by parameter stopQueryType.
        /// </summary>
        Stops,
        /// <summary>
        /// Returns the next live arrival times for each stop within the specified line. lineId, for example, '3785742'.
        /// </summary>
        Line,

        /// <summary>
        /// Returns up to three next Live Arrival times for a given line at a given stop. Comma-separated list including lineId and stop identifier, for example, 1228526,14014071 (lineId, stopId).
        /// </summary>
        LineAndStop,

        /// <summary>
        /// Returns arrivals of a line to stops near the user’s location. The applicable location query specified as a comma separated string composed by latitude followed by longitude e.g. "47.641268,-122.125679".
        /// </summary>
        Position


    }
}