using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Render
{
    /// <summary>
    /// This object is returned from a successful Copyright Caption call
    /// </summary>
    public class CopyrightCaptionResult
    {
        /// <summary>
        /// Copyrights Caption property
        /// </summary>
        [JsonProperty("copyrightsCaption")]
        public string CopyrightsCaption { get; set; }

        /// <summary>
        /// Format Version property
        /// </summary>
        [JsonProperty("formatVersion")]
        public string FormatVersion { get; set; }
    }
}
