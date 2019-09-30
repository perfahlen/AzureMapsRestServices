namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// A list of alert details.
    /// </summary>
    public class AlertDetail
    {
        /// <summary>
        /// The start time of the alert in the local time in ISO format (2019-04-05T14:24:18-04:00).
        /// </summary>
        public string ActiveFrom { get; set; }

        /// <summary>
        /// The estimated end time of the alert in the local time in ISO format (2019-04-05T14:24:18-04:00).
        /// </summary>
        public string ActiveTo { get; set; }

        /// <summary>
        /// The Id of the relevant transit agency, for example, '5872'.
        /// </summary>
        public string AgencyId { get; set; }

        /// <summary>
        /// Name of the relevant transit agency, e.g. Metro Transit.
        /// </summary>
        public string AgencyName { get; set; }

        /// <summary>
        /// A short description of the alert.
        /// </summary>
        public AlertDescription Description { get; set; }

        /// <summary>
        /// Service Alert effect - one of SA_NO_SERVICE, SA_REDUCED_SERVICE, SA_SIGNIFICANT_DELAYS, SA_DETOUR, SA_ADDITIONAL_SERVICE, SA_MODIFIED_SERVICE, SA_OTHER_EFFECT, SA_STOP_MOVED, SA_GOOD_SERVICE, SA_SLEEPING, SA_OTHER_EFFECT
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        /// The title of the alert.
        /// </summary>
        public string Title { get; set; }
    }
}