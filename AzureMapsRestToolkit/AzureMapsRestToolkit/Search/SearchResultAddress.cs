using Newtonsoft.Json;

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
        [JsonProperty("buildingNumber")]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Country property
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Country Code property
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Country Code ISO3 property
        /// </summary>
        [JsonProperty("countryCodeISO3")]
        public string CountryCodeISO3 { get; set; }

        /// <summary>
        /// Country Secondary Subdivision property
        /// </summary>
        [JsonProperty("countrySecondarySubdivision")]
        public string CountrySecondarySubdivision { get; set; }

        /// <summary>
        /// Country Subdivision property
        /// </summary>
        [JsonProperty("countrySubdivision")]
        public string CountrySubdivision { get; set; }

        /// <summary>
        /// Country Subdividion Name property
        /// </summary>
        [JsonProperty("countrySubdivisionName")]
        public string CountrySubdivisionName { get; set; }

        /// <summary>
        /// Country Tertiary Subdivision property
        /// </summary>
        [JsonProperty("countryTertiarySubdivision")]
        public string CountryTertiarySubdivision { get; set; }

        /// <summary>
        /// Cross Street property
        /// </summary>
        [JsonProperty("crossStreet ")]
        public string CrossStreet { get; set; }

        /// <summary>
        /// Extended Postal Code property
        /// </summary>
        [JsonProperty("extendedPostalCode")]
        public string ExtendedPostalCode { get; set; }

        /// <summary>
        /// Free form Address property
        /// </summary>
        [JsonProperty("freeformAddress")]
        public string FreeformAddress { get; set; }

        /// <summary>
        /// Municipality property
        /// </summary>
        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        /// <summary>
        /// Municipality Subdivision property
        /// </summary>
        [JsonProperty("municipalitySubdivision")]
        public string MunicipalitySubdivision { get; set; }

        /// <summary>
        /// Postal Code property
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// number of routes
        /// </summary>
        [JsonProperty("routeNumbers")]
        public int[] RouteNumbers { get; set; }

        /// <summary>
        /// Street property
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Street Name property
        /// </summary>
        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// Street Name and Number property
        /// </summary>
        [JsonProperty("streetNameAndNumber")]
        public string StreetNameAndNumber { get; set; }

        /// <summary>
        /// Street Number property
        /// </summary>
        [JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }
    }
}