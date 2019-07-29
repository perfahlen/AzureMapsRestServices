namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// Specifies the agency identifier to request routes from a specific set of agencies to be returned. By default the agencyType=agencyId.
    /// </summary>
    public enum AgencyType
    {
        /// <summary>
        /// The Id of the transit agency, e.g. '5872'
        /// </summary>
        AgencyId,

        /// <summary>
        /// The agency’s GTFS Id.
        /// </summary>
        AgencyKey,

        /// <summary>
        /// The name of the transit agency, e.g. Metro Transit.
        /// </summary>
        AgencyName
    }
}