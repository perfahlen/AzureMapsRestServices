using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AzureMapsToolkit.Mobility
{
    public class LineGroup
    {
        /// <summary>
        /// The Id of the transit agency, for example, '5872'.
        /// </summary>
        public string AgencyId { get; set; }

        /// <summary>
        /// The name of the transit agency, e.g. Metro Transit.
        /// </summary>
        public string AgencyName { get; set; }

        /// <summary>
        /// A descriptive string. In case caption2 is null, should be used alone as a subtitle to the line number (i.e. Circular). In case caption2 has a value present, should be used in conjunction with it (i.e. Rome ↔ Napoli).
        /// </summary>
        public string Caption1 { get; set; }

        /// <summary>
        /// A desciptive string.
        /// </summary>
        public string Caption2 { get; set; }

        /// <summary>
        /// HEX color for the line.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Line group Id. Typically contains 2 lines having the same agency and line, one going from A to B, and the other from B to A.
        /// </summary>
        public string LineGroupId { get; set; }

        /// <summary>
        /// The transit line number.
        /// </summary>
        public string LineNumber { get; set; }

        /// <summary>
        /// The public transit type of the line.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TransitType TransitType { get; set; }
    }
}