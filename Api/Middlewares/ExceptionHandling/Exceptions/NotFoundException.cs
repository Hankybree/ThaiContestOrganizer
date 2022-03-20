using System.Net;

namespace Api.Middlewares.ExceptionHandling.Exceptions;

public class NotFoundException : RestBaseException
{
    public NotFoundException() : base("Entity not found", HttpStatusCode.NotFound)
    {

    }

    public NotFoundException(string message) : base(message, HttpStatusCode.NotFound)
    {

    }
}
