namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// A stop line
    /// </summary>
    public class Line
    {
        /// <summary>
        /// The Id of the transit agency, for example, '5872'.
        /// </summary>
        public string AgencyId { get; set; }

        /// <summary>
        /// The name of the transit agency, for example, 'NJ Transit'.
        /// </summary>
        public string AgencyName { get; set; }

        /// <summary>
        /// Line direction. Possible values 'forward' or 'backward'.
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// The line’s user displayable destination.
        /// </summary>
        public string LineDestination { get; set; }

        /// <summary>
        /// Line group Id. Typically contains 2 lines having the same agency and line, one going from A to B, and the other from B to A.
        /// </summary>
        public string LineGroupId { get; set; }

        /// <summary>
        /// Line Id
        /// </summary>
        public string LineId { get; set; }

        /// <summary>
        /// The transit line number.
        /// </summary>
        public string LineNumber { get; set; }

        /// <summary>
        /// Most common pattern for the line.
        /// </summary>
        public string MostFrequentPatternId { get; set; }

        /// <summary>
        /// The line’s origin, will be present according to metro settings.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// The public transit type of the line.
        /// </summary>
        public TransitType TransitType { get; set; }


    }
}