using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AzureMapsToolkit
{
    /// <summary>
    /// This object is returned when an error occurs in the Maps API
    /// </summary>
    public class Error
    {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// If available, a human readable description of the error.
        /// </summary>
        [JsonPropertyName("message")] 
        public string Message { get; set; }
    }

}
