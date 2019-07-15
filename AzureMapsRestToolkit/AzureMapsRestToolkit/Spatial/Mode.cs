namespace AzureMapsToolkit.Spatial
{
    /// <summary>
    /// Mode of the geofencing async event mechanism.
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// Publish all the query results to Azure Maps account event subscription.
        /// </summary>
        All,

        /// <summary>
        /// Only publish result when user location is considered as crossing geofencing boarder.
        /// </summary>
        EnterAndExit
    }
}