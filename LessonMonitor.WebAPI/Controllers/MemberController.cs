using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LessonMonitor.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly string[] _names = { "Bohdan", "Nazar", "Vasyl", "Roman" };

        [HttpGet]
        public IActionResult Get()
        {
            var rnd = new Random();

            return Ok(new Member 
            {
                MemberID = rnd.Next(0, 500),
                Age = rnd.Next(10, 20), 
                FirstName = _names[rnd.Next(0, _names.Length)],
                LastName = _names[rnd.Next(0, _names.Length)],
                Group = new Group()
            });
        }
    }
}
