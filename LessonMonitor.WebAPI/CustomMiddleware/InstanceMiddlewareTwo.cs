using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware
{
    public class InstanceMiddlewareTwo
    {
        private readonly RequestDelegate next;

        public InstanceMiddlewareTwo(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            //before next middleware block calling
            System.Console.WriteLine("InstanceMiddlewareTwo before");
            var result = next.Invoke(context);
            //after next middleware block completing
            System.Console.WriteLine("InstanceMiddlewareTwo after");
            return result;
        }
    }
}
