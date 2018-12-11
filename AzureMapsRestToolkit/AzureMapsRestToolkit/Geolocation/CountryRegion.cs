namespace AzureMapsToolkit.Geolocation
{
    /// <summary>
    /// The object containing the country/region information.
    /// </summary>
    public class CountryRegion
    {
        /// <summary>
        /// The IP Address's 2-character code (ISO 3166-1) of the country or 
        /// region as assigned by IANA and regional internet authorities. Please note, IP address in ranges reserved for special purpose will return Null for country/region.
        /// </summary>
        public string IsoCode { get; set; }
    }
}
