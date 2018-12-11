using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit
{
    /// <summary>
    /// This response object is returned when an error occurs in the Maps API
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// This object is returned when an error occurs in the Maps API
        /// </summary>
        public Error Error { get; set; }

    }
}
