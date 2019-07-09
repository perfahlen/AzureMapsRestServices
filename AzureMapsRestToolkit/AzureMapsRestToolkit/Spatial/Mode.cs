namespace AzureMapsToolkit.Spatial
{
    /// <summary>
    /// Mode of the geofencing async event mechanism.
    /// </summary>
    public class Mode
    {
        /// <summary>
        /// Publish all the query results to Azure Maps account event subscription.
        /// </summary>
        public string All { get; set; }

        /// <summary>
        /// Only publish result when user location is considered as crossing geofencing boarder.
        /// </summary>
        public string EnterAndExit { get; set; }
    }
}