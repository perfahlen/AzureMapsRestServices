using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// The address of the result
    /// </summary>
    public class SearchResultAddress
    {
        /// <summary>
        /// Building Number property
        /// </summary>
        [JsonPropertyName("buildingNumber")]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Country property
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Country Code property
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Country Code ISO3 property
        /// </summary>
        [JsonPropertyName("countryCodeISO3")]
        public string CountryCodeISO3 { get; set; }

        /// <summary>
        /// Country Secondary Subdivision property
        /// </summary>
        [JsonPropertyName("countrySecondarySubdivision")]
        public string CountrySecondarySubdivision { get; set; }

        /// <summary>
        /// Country Subdivision property
        /// </summary>
        [JsonPropertyName("countrySubdivision")]
        public string CountrySubdivision { get; set; }

        /// <summary>
        /// Country Subdividion Name property
        /// </summary>
        [JsonPropertyName("countrySubdivisionName")]
        public string CountrySubdivisionName { get; set; }

        /// <summary>
        /// Country Tertiary Subdivision property
        /// </summary>
        [JsonPropertyName("countryTertiarySubdivision")]
        public string CountryTertiarySubdivision { get; set; }

        /// <summary>
        /// Cross Street property
        /// </summary>
        [JsonPropertyName("crossStreet ")]
        public string CrossStreet { get; set; }

        /// <summary>
        /// Extended Postal Code property
        /// </summary>
        [JsonPropertyName("extendedPostalCode")]
        public string ExtendedPostalCode { get; set; }

        /// <summary>
        /// Free form Address property
        /// </summary>
        [JsonPropertyName("freeformAddress")]
        public string FreeformAddress { get; set; }

        /// <summary>
        /// Municipality property
        /// </summary>
        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }

        /// <summary>
        /// Municipality Subdivision property
        /// </summary>
        [JsonPropertyName("municipalitySubdivision")]
        public string MunicipalitySubdivision { get; set; }

        /// <summary>
        /// Postal Code property
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// number of routes
        /// </summary>
        [JsonPropertyName("routeNumbers")]
        public string[] RouteNumbers { get; set; }

        /// <summary>
        /// Street property
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }

        /// <summary>
        /// Street Name property
        /// </summary>
        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// Street Name and Number property
        /// </summary>
        [JsonPropertyName("streetNameAndNumber")]
        public string StreetNameAndNumber { get; set; }

        /// <summary>
        /// Street Number property
        /// </summary>
        [JsonPropertyName("streetNumber")]
        public string StreetNumber { get; set; }
    }
}