using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.CustomMiddleware
{
    public class InstanceMiddleware
    {
        private readonly RequestDelegate next;

        public InstanceMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            //before next middleware block calling
            var result = next.Invoke(context);
            //after next middleware block completing
            return result;
        }
    }
}
