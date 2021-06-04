using System.Text.Json.Serialization;
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
        [JsonPropertyName("numResults")]
        public int NumResults { get; set; }

        /// <summary>
        /// QueryTime property
        /// </summary>
        [JsonPropertyName("queryTime")]
        public int QueryTime { get; set; }
    }
}
