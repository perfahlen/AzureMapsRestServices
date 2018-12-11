using System;
using System.Collections.Generic;
using System.Text;

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
        public string Code { get; set; }

        /// <summary>
        /// If available, a human readable description of the error.
        /// </summary>
        public string Message { get; set; }
    }

}
