using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class BufferResponse
    {
        [JsonProperty("result")]
        public object Result { get; set; }

        [JsonProperty("results")]
        public object Results { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }
    }

}
