using Newtonsoft.Json;
using System.Net;

namespace ConsoleApp1.Infrastructure
{
    public class MiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<MiddleWare> _logger;
        public MiddleWare(RequestDelegate next, ILogger<MiddleWare> logger)
        {
            _logger = logger;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                await HandleGlobalException(httpContext, ex);
            }
        }
        private async Task<dynamic> HandleGlobalException(HttpContext context, Exception exception)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";
            var response = new { StatusText = "Error :: - " + exception.Message + "- \n - " + exception.InnerException.Message };
            var json = JsonConvert.SerializeObject(response);

            await context.Response.WriteAsync(json);
            return null;
        }
    }
}
