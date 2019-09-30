namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// This object is returned from a successful Get Transit Stop Info call
    /// </summary>
    public class TransitStopInfoResponse
    {
        /// <summary>
        /// A list of stop alerts
        /// </summary>
        public TransitStopAlert[] Alerts { get; set; }

        /// <summary>
        /// A list of line groups
        /// </summary>
        public LineGroup[] LineGroups { get; set; }

        /// <summary>
        /// A list of stop lines
        /// </summary>
        public Line[] Lines { get; set; }

        /// <summary>
        /// The stop's basic info
        /// </summary>
        public Stop Stop { get; set; }
    }
}
