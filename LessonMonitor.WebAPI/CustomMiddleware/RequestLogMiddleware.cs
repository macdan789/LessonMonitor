using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware
{
    public class RequestLogMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await File.AppendAllTextAsync("LogFile.log", $"{DateTime.Now}[Request]{context.Request.Path}\n");
            
            await _next(context);

            await File.AppendAllTextAsync("LogFile.logs", $"{DateTime.Now}[Response]{context.Response.StatusCode}\n");
        }
    }

    public static class RequestLogMiddlewareExtention
    {
        public static void UseRequestLogMiddleware(this IApplicationBuilder app)
            => app.UseMiddleware<RequestLogMiddleware>();
    }
}
