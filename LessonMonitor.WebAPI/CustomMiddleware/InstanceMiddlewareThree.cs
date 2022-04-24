using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware
{
    public class InstanceMiddlewareThree
    {
        private readonly RequestDelegate next;

        public InstanceMiddlewareThree(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            //before next middleware block calling
            System.Console.WriteLine("InstanceMiddlewareThree before");
            var result = next.Invoke(context);
            //after next middleware block completing
            System.Console.WriteLine("InstanceMiddlewareThree after");
            return result;
        }
    }
}
