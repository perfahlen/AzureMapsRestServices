using System.Text.Json;
using System;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Data
{
    public class UploadResult
    {
        /// <summary>
        /// The unique data id for the data.
        /// </summary>
        [JsonPropertyName("udid")]
        public Guid Udid { get; set; }
    }
}
