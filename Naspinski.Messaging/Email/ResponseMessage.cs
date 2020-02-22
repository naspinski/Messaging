using System;
using System.Collections.Generic;
using System.Text;

namespace Naspinski.Messaging.Email
{
    public class ResponseMessage
    {
        public ResponseMessage(string statusCode)
        {
            this.StatusCode = statusCode;
        }

        public string StatusCode { get; }
    }
}
