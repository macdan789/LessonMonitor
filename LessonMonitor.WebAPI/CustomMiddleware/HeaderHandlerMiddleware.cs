using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware;

public class HeaderHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly string responseHeader = "X-Test-Response-Header";
    private readonly string requestHeader = "X-Test-Request-Header";

    public HeaderHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        //should add new custom headers to response before it is formed
        if (context.Request.Headers.Keys.Any(x => string.Equals(x, requestHeader, StringComparison.OrdinalIgnoreCase)))
            context.Response.Headers.Add(responseHeader, "Hello from Bohdan Marko");

        await _next(context);
    }
}

public static class HeaderHandlerMiddlewareExtention
{
    public static void UseHeaderHandlerMiddleware(this IApplicationBuilder app)
        => app.UseMiddleware<HeaderHandlerMiddleware>();
}
