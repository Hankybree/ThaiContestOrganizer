using System;
using System.Net;

namespace Api.Exceptions
{
    public abstract class RestBaseException : Exception
    {
        public HttpStatusCode Status { get; set; }

        public RestBaseException(string message, HttpStatusCode status) : base(message)
        {
            Status = status;
        }
    }
}
