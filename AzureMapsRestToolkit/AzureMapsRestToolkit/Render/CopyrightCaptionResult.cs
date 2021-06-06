using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("copyrightsCaption")]
        public string CopyrightsCaption { get; set; }

        /// <summary>
        /// Format Version property
        /// </summary>
        [JsonPropertyName("formatVersion")]
        public string FormatVersion { get; set; }
    }
}
