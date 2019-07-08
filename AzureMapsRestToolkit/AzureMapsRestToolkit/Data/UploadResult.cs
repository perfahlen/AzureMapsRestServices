using Newtonsoft.Json;
using System;

namespace AzureMapsToolkit.Data
{
    public class UploadResult
    {
        /// <summary>
        /// The unique data id for the data.
        /// </summary>
        [JsonProperty("udid")]
        public Guid Udid { get; set; }
    }
}
