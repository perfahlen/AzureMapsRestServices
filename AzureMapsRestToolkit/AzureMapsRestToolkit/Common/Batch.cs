using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Common
{
    public class Batch
    {
        [JsonPropertyName("batchItems")]
        public List<BatchItem> BatchItems { get; set; }
    }
}
