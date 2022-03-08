﻿using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LessonMonitor.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly string[] _names = { "Bohdan", "Nazar", "Vasyl", "Roman" };

        [HttpGet]
        public IActionResult Get()
        {
            var rnd = new Random();

            return Ok(new Member { Age = rnd.Next(10, 20), Name = _names[rnd.Next(0, _names.Length)]});
        }
    }
}
