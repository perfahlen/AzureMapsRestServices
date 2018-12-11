using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseCrossStreetRequest : SearchRequestBase
    {
        /// <summary>
        /// The directional heading of the vehicle in degrees, for travel along a segment of roadway. 0 is North, 90 is East and so on, values range from -360 to 360. The precision can include upto one decimal place
        /// </summary>
        public int Heading { get; set; }

        /// <summary>
        /// The radius in meters to for the results to be constrained to the defined area
        /// </summary>
        public double? Radius { get; set; }
    }
}
