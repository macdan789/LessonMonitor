using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware
{
    public class InstanceMiddlewareOne
    {
        private readonly RequestDelegate next;

        public InstanceMiddlewareOne(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            //before next middleware block calling
            System.Console.WriteLine("InstanceMiddlewareOne before");
            var result = next.Invoke(context);
            //after next middleware block completing
            System.Console.WriteLine("InstanceMiddlewareOne after");
            return result;
        }
    }
}
