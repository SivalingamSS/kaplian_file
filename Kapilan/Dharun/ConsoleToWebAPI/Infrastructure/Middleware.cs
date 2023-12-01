using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;

namespace ConsoleToWebAPI.Infrastructure
{
    public class Middleware
    {
            private readonly RequestDelegate _next;
            private readonly ILogger<Middleware> _logger;
            public Middleware(RequestDelegate next, ILogger<Middleware> logger)
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
                var response = new { StatusText = "Error :: - " + exception.Message + "- \n  - " + exception.InnerException.Message };
                var json = JsonConvert.SerializeObject(response);

                await context.Response.WriteAsync(json);
                return null;
            }
        }
    }