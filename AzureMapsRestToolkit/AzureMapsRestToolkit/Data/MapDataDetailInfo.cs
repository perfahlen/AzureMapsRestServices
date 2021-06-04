using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit.Data
{
    public class MapDataDetailInfo
    {
        /// <summary>
        /// The location of the data. Execute a HTTP GET on this location to download the data.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// The size of the content in bytes.
        /// </summary>
        [JsonPropertyName("sizeInBytes")]
        public int SizeInBytes { get; set; }

        /// <summary>
        /// The unique data id for the data.
        /// </summary>
        [JsonPropertyName("udid")]
        public string Udid { get; set; }

        /// <summary>
        /// The current upload status of the content.
        /// </summary>
        [JsonPropertyName("uploadStatus")]
        public string UploadStatus { get; set; }
    }
}
