using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Search
{
    public class SearchAddressReverseSummary
    {
        /// <summary>
        /// NumResults property
        /// </summary>
        [JsonProperty("numResults")]
        public int NumResults { get; set; }

        /// <summary>
        /// QueryTime property
        /// </summary>
        [JsonProperty("queryTime")]
        public int QueryTime { get; set; }
    }
}
