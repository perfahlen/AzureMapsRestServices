using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzureMapsToolkit.Common
{
    public class BatchItem
    {
        [JsonPropertyName("query")]
        public string Query { get; set; }
    }
}
