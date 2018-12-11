using AzureMapsToolkit.Common;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressStructuredRequest : SearchRequestBaseExtended
    {
        /// <summary>
        /// The country subdividion portion of an address
        /// </summary>
        public string CountrySubdivision { get; set; }

        /// <summary>
        /// The county for the structured address
        /// </summary>
        public string CountrySecondarySubdivision { get; set; }

        /// <summary>
        /// The named area for the structured address
        /// </summary>
        public string CountryTertiarySubdivision { get; set; }

        /// <summary>
        /// The municipality subdivision (sub/super city) for the structured address
        /// </summary>
        public string MunicipalitySubdivision { get; set; }

        /// <summary>
        /// The municipality portion of an address
        /// </summary>
        public string Municipality { get; set; }

        /// <summary>
        /// The cross street name for the structured address
        /// </summary>
        public string CrossStreet { get; set; }

        /// <summary>
        /// The postal code portion of an address
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The street name portion of an address
        /// </summary>
        public string StreetName { get; set; }
        
        /// <summary>
        /// The 2 or 3 letter ISO3166-1 country code portion of an address. E.g. US.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// The street number portion of an address
        /// </summary>
        public string StreetNumber { get; set; }

    }
}
