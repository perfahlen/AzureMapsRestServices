using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Data
{
    public class MapDataListResponse
    {
        /// <summary>
        /// A list of all the previously uploaded data.
        /// </summary>
        [JsonProperty("mapDataList")]
        public List<MapDataDetailInfo> MapDataList { get; set; }
    }
}
