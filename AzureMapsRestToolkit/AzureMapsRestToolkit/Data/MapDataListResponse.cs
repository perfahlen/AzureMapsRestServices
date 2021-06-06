using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Data
{
    public class MapDataListResponse
    {
        /// <summary>
        /// A list of all the previously uploaded data.
        /// </summary>
        [JsonPropertyName("mapDataList")]
        public List<MapDataDetailInfo> MapDataList { get; set; }
    }
}
