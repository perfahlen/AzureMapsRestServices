namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// The magnitude of delay caused by the incident. These values correspond to the values of the response field of the Get Traffic Incident Detail API.
    /// </summary>
    public enum MagnitudeOfDelay
    {
        Unknown = 0,
        Minro = 1,
        Moderate = 2,
        Major = 3,
        /// <summary>
        /// Undefined, used for road closures and other indefinite delays.
        /// </summary>
        Undefined = 4
    }
}
