using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Mobility
{
    public class TransitStopAlert : Alert
    {
        /// <summary>
        /// A list of alert details.
        /// </summary>
        public AlertDetail Details { get; set; }

        /// <summary>
        /// The date and time in ISO 8601 format, e.g. 2019-04-05T14:24:18-04:00.
        /// </summary>
        public string PublicationDate { get; set; }
    }
}
