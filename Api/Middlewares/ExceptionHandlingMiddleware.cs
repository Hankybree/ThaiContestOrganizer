using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ThaiContestApi.Models.Dto;
using ThaiContestApi.Exceptions;

namespace ThaiContestApi.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch(RestBaseException ex)
            {
                await HandleException(httpContext, ex.Status, ex.Message);
            }
            catch(Exception ex)
            {
                await HandleException(httpContext, HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        private async Task HandleException(HttpContext httpContext, HttpStatusCode status, string message)
        {
            int statusCode = (int)status;
            string reason = status.ToString();

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            await httpContext.Response.WriteAsJsonAsync(new ErrorDto()
            {
                StatusCode = statusCode,
                Reason = reason,
                Message = message
            });
        }
    }

    public static class ExceptionHandlingMiddlewareExtenstion
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
