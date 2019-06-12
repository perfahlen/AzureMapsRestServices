using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Data
{
    public class MapDataDetailInfo
    {
        /// <summary>
        /// The location of the data. Execute a HTTP GET on this location to download the data.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// The size of the content in bytes.
        /// </summary>
        [JsonProperty("sizeInBytes")]
        public int SizeInBytes { get; set; }

        /// <summary>
        /// The unique data id for the data.
        /// </summary>
        [JsonProperty("udid")]
        public string Udid { get; set; }

        /// <summary>
        /// The current upload status of the content.
        /// </summary>
        [JsonProperty("uploadStatus")]
        public string UploadStatus { get; set; }
    }
}
