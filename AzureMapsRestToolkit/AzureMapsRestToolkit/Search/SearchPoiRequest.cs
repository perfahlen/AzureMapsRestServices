using System.Globalization;

namespace AzureMapsToolkit.Search
{
    public class SearchPoiRequest : SearchNearbyRequest
    {
        /// <summary>
        /// The POI name to search for (e.g., "statue of liberty", "starbucks"), must be properly URL encoded.
        /// </summary>
        public new string Query { get; set; }

        /// <summary>
        /// Boolean. If the typeahead flag is set, the query will be interpreted as a partial input and the search will enter predictive mode
        /// </summary>
        public bool? Typeahead { get; set; }
        /// <summary>
        /// A comma-separated list of brand names which could be used to restrict the result to specific brands. Item order does not matter. When multiple brands are provided, only results that belong to (at least) one of the provided list will be returned. Brands that contain a "," in their name should be put into quotes.
        /// Usage examples: brandSet=Foo,Bar  brandSet=Foo  brandSet="A,B,C Comma",Bar
        /// </summary>
        public string BrandSet { get; set; }

        /// <summary>
        /// Bottom right position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string BtmRight { get; set; }

        /// <summary>
        /// A comma-separated list of connector types which could be used to restrict the result to Electric Vehicle Station supporting specific connector types. Item order does not matter. When multiple connector types are provided, only results that belong to (at least) one of the provided list will be returned.
        /// 
        /// Available connector types are:
        /// - StandardHouseholdCountrySpecific - These are the standard household connectors for a certain region. They are all AC single phase and the standard Voltage and standard Amperage. See also: Plug & socket types - World Standards.
        /// - IEC62196Type1 - Type 1 connector as defined in the IEC 62196-2 standard. Also called Yazaki after the original manufacturer or SAE J1772 after the standard that first published it. Mostly used in combination with 120V single phase or up to 240V single phase infrastructure.
        /// - IEC62196Type1CCS - Type 1 based combo connector as defined in the IEC 62196-3 standard. The connector is based on the Type 1 connector – as defined in the IEC 62196-2 standard – with two additional direct current (DC) contacts to allow DC fast charging.
        /// - IEC62196Type2CableAttached - Type 2 connector as defined in the IEC 62196-2 standard. Provided as a cable and plug attached to the charging point.
        /// - IEC62196Type2Outlet - Type 2 connector as defined in the IEC 62196-2 standard. Provided as a socket set into the charging point.
        /// - IEC62196Type2CCS - Type 2 based combo connector as defined in the IEC 62196-3 standard. The connector is based on the Type 2 connector – as defined in the IEC 62196-2 standard – with two additional direct current (DC) contacts to allow DC fast charging.
        /// - IEC62196Type3 - Type 3 connector as defined in the IEC 62196-2 standard. Also called Scame after the original manufacturer. Mostly used in combination with up to 240V single phase or up to 420V three phase infrastructure.
        /// - Chademo - CHAdeMO connector named after an association formed by the Tokyo Electric Power Company and industrial partners. Because of this is is also known as the TEPCO's connector. It supports fast DC charging.
        /// - IEC60309AC1PhaseBlue - Industrial Blue connector is a connector defined in the IEC 60309 standard. It is sometime referred to as by some combination of the standard, the color and the fact that is a single phase connector. The connector usually has the "P+N+E, 6h" configuration.
        /// - IEC60309DCWhite - Industrial White connector is a DC connector defined in the IEC 60309 standard.
        /// - Tesla - The Tesla connector is the regionally specific Tesla Supercharger connector. I.e. it refers to either Tesla's proprietary connector, sometimes referred to as Tesla Port mostly limited to North America or the modified Type 2 (DC over Type 2) in Europe.
        /// Usage examples:connectorSet=IEC62196Type2CableAttached
        /// connectorSet=IEC62196Type2Outlet,IEC62196Type2CableAttached
        /// </summary>
        public string ConnectorSet { get; set; }

        /// <summary>
        /// Opening hours for a POI (Points of Interest). The availability of opening hours will vary based on the data available.
        /// </summary>
        public string OpeningHours { get; set; }

        /// <summary>
        /// Top left position of the bounding box. E.g. 37.553,-122.453
        /// </summary>
        public string TopLeft { get; set; }

        /// <summary>
        /// The View parameter specifies which set of geopolitically disputed content is returned via Azure Maps services, including borders and labels displayed on the map. The View parameter (also referred to as “user region parameter”) will show the correct maps for that country/region. By default, the View parameter is set to “Unified” even if you haven’t defined it in the request. It is your responsibility to determine the location of your users, and then set the View parameter correctly for that location. Alternatively, you have the option to set ‘View=Auto’, which will return the map data based on the IP address of the request. The View parameter in Azure Maps must be used in compliance with applicable laws, including those regarding mapping, of the country where maps, images and other data and third party content that you are authorized to access via Azure Maps is made available. Example: view=IN.
        /// Please refer to Supported Views for details and to see the available Views.
        /// </summary>
        public string View { get; set; }

    }
}
