namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// This object is returned from a successful Transit Line Info call.
    /// </summary>
    public class TransitLineInfoResponse
    {
        /// <summary>
        /// Groups together all lines that are logically part of the same group. Typically contains 2 lines having the same agency and line, one going from A to B, and the other from B to A.
        /// </summary>
        public LineGroup LineGroup { get; set; }

        /// <summary>
        /// The line group’s basic info and list of the lines.
        /// </summary>
        public Line[] Lines { get; set; }

        /// <summary>
        /// List of patterns this group is comprised of. A pattern consists of a stop sequence and shape per a line in GeoJSON format.
        /// </summary>
        public Pattern[] Patterns { get; set; }

        public LineArrival[] Schedule { get; set; }

        public Stop[] Stops { get; set; }
    }
}
