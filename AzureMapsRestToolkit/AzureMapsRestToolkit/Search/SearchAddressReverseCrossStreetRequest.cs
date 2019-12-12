using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseCrossStreetRequest : SearchRequestBase
    {
        /// <summary>
        /// The directional heading of the vehicle in degrees, for travel along a segment of roadway. 0 is North, 90 is East and so on, values range from -360 to 360. The precision can include upto one decimal place
        /// </summary>
        public int? Heading { get; set; }

        /// <summary>
        /// The radius in meters to for the results to be constrained to the defined area
        /// </summary>
        public double? Radius { get; set; }

        /// <summary>
        /// The View parameter specifies which set of geopolitically disputed content is returned via Azure Maps services, including borders and labels displayed on the map. The View parameter (also referred to as “user region parameter”) will show the correct maps for that country/region. By default, the View parameter is set to “Unified” even if you haven’t defined it in the request. It is your responsibility to determine the location of your users, and then set the View parameter correctly for that location. Alternatively, you have the option to set ‘View=Auto’, which will return the map data based on the IP address of the request. The View parameter in Azure Maps must be used in compliance with applicable laws, including those regarding mapping, of the country where maps, images and other data and third party content that you are authorized to access via Azure Maps is made available. Example: view=IN.
        /// </summary>
        public string View { get; set; }
    }
}
