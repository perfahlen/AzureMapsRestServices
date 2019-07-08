using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Common
{
    public class AzureMapsException : Exception
    {

        string message = string.Empty;
        string code = string.Empty;

        public AzureMapsException(ErrorResponse responseMsg)
        {
            this.message = responseMsg.Error.Message;
            this.code = responseMsg.Error.Code;
        }


        /// <summary>
        /// Response Message
        /// </summary>
        public override string Message => this.message;

        /// <summary>
        /// Response Code
        /// </summary>
        public string Code => this.code;
    }
}
