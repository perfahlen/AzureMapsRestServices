using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Traffic
{
    public class TrafficIncidentTileRequest : TrafficRequestTileBase
    {

        /// <summary>
        /// Reference value for the state of traffic at a particular time, obtained from the Viewport API call, trafficModelId attribute in trafficState field. It is updated every minute, and is valid for two minutes before it times out. Use -1 to get the most recent traffic information. Default: most recent traffic information.
        /// </summary>
        public string T { get; set; }

        public TrafficIncidentTileStyle Style { get; set; }

    }
}
