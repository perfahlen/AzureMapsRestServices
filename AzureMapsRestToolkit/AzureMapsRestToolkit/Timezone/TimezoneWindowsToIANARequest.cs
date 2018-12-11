using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Timezone
{
    public class TimezoneWindowsToIANARequest : RequestBase
    {
        /// <summary>
        /// The applicable query string. Must be properly URL encoded.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Windows Time Zone territory code.
        /// </summary>
        public string Territory { get; set; }
    }
}
