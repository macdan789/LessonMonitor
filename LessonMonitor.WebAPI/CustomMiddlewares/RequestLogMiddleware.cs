using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddlewares;

public class RequestLogMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLogMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await File.AppendAllLinesAsync("LogFile.log", 
            new string[] { $"{DateTime.Now}[Request]{context.Request.Path}" });

        await _next(context);

        await File.AppendAllLinesAsync("LogFile.log", 
            new string[] { $"{DateTime.Now}[Response]{context.Request.Path} Status:{context.Response.StatusCode}" });
    }
}

public static class RequestLogMiddlewareExtention
{
    public static void UseRequestLogMiddleware(this IApplicationBuilder app)
        => app.UseMiddleware<RequestLogMiddleware>();
}
