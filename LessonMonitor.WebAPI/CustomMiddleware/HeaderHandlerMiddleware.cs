using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware
{
    public class HeaderHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public HeaderHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //should add new custom headers to response before it is formed
            if (context.Request.Headers.Keys.Any(x => string.Equals(x, "X-Test-Request-Header", StringComparison.OrdinalIgnoreCase)))
                context.Response.Headers.Add("X-Test-Response-Header", "Hello from Bohdan Marko");

            await _next(context);
        }
    }

    public static class HeaderHandlerMiddlewareExtention
    {
        public static void UseHeaderHandlerMiddleware(this IApplicationBuilder app) 
            => app.UseMiddleware<HeaderHandlerMiddleware>();
    }
}
