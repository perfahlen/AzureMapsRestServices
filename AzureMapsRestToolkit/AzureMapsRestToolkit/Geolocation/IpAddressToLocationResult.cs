using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Geolocation
{
    /// <summary>
    /// This object is returned from a successful call to IP Address to country/region API
    /// </summary>
    public class IpAddressToLocationResult
    {
        /// <summary>
        /// The object containing the country/region information.
        /// </summary>
        public CountryRegion CountryRegion { get; set; }

        /// <summary>
        /// The IP Address of the request.
        /// </summary>
        public string IPAddress { get; set; }
    }
}
