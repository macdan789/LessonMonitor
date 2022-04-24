using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware
{
    public class RequestLogMiddleware
    {
        private readonly RequestDelegate next;

        public RequestLogMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await File.AppendAllTextAsync("LogFile.txt", $"{DateTime.Now}[Request]{context.Request.Path}\n");
            
            await this.next(context);

            await File.AppendAllTextAsync("LogFile.txt", $"{DateTime.Now}[Response]{context.Response.StatusCode}\n");
        }
    }

    public static class RequestLogMiddlewareExtention
    {
        public static void UseRequestLogMiddleware(this IApplicationBuilder app)
            => app.UseMiddleware<RequestLogMiddleware>();
    }
}
