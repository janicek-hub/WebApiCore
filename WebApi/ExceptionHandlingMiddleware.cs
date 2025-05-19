using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace WebApi
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context); // pokračuj v řetězci middleware
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception occurred");

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var problem = new ProblemDetails
                {
                    Title = "Internal Server Error",
                    Status = context.Response.StatusCode,
                    Detail = ex.Message,
                    Type = ex.GetType().ToString()
                };

#if DEBUG
                problem.Extensions["stackTrace"] = ex.StackTrace;
#endif

                var json = JsonSerializer.Serialize(problem);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
