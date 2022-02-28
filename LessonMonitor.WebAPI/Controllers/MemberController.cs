using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Member { Age = 18, Name = "Bohdan"});
        }
    }
}
