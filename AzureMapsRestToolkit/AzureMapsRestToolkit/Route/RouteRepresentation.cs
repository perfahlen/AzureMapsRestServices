namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Specifies the representation of the set of routes provided as response. This parameter value can only be used in conjunction with computeBestOrder=true
    /// </summary>
    public enum RouteRepresentation
    {
        /// <summary>
        /// Includes only the optimized waypoint indices but does not include the route geometry in the response.
        /// </summary>
        none,

        /// <summary>
        /// Includes route geometry in the response.
        /// </summary>
        polyline,

        /// <summary>
        /// Summary as per polyline but excluding the point geometry elements for the routes in the response.
        /// </summary>
        summaryOnly
    }
}
