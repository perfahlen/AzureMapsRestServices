using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class BufferResponse
    {
        [JsonPropertyName("result")]
        public object Result { get; set; }

        [JsonPropertyName("results")]
        public object Results { get; set; }

        [JsonPropertyName("summary")]
        public Summary Summary { get; set; }
    }

}
