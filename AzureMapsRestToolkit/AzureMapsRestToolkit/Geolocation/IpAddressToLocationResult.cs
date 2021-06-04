using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("countryRegion")]
        public CountryRegion CountryRegion { get; set; }

        /// <summary>
        /// The IP Address of the request.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IPAddress { get; set; }
    }
}
