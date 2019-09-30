using AzureMapsToolkit.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Mobility
{
    public class CarShareInfoRequest : RequestBase
    {
        /// <summary>
        /// vehicleId. The unique identifier of the car share vehicle. For example, "29B8C4AFC062D681E050007F01004F07". Can be requested by using Nearby Transit API.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Language in which search results will be returned. Only NGT is supported. Please refer to Supported languages for details.
        /// </summary>
        public string Language { get; set; }
    }
}
