namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// Controls the optimality, with respect to the given planning criteria, of the calculated alternatives compared to the reference route.
    /// </summary>
    public enum AlternativeRouteType
    {
        /// <summary>
        /// Allow any alternative route to be returned irrespective of how it compares to the reference route in terms of optimality.
        /// </summary>
        anyRoute,

        /// <summary>
        /// Return an alternative route only if it is better than the reference route according to the given planning criteria.
        /// </summary>
        betterRoute
    }
}
