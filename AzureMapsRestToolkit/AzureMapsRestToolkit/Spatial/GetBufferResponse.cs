using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Spatial
{
    public class GetBufferResponse
    {
        [JsonProperty("results")]
        public object Result { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }
    }
}
