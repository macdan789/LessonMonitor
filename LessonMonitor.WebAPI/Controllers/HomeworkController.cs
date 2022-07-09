using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.AbstractCore.DboModel;
using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeworkController : Controller
{
    private readonly IHomeworkService _homeworkService;

    public HomeworkController(IHomeworkService homeworkService)
    {
        _homeworkService = homeworkService;
    }

    [HttpPost]
    [Route("[action]")]
    public IActionResult CreateHomework([FromBody] Homework homework)
    {
        //Simple Mapping
        var homeworkDto = new HomeworkDto
        {
            Title = homework.Title,
            Subject = homework.Subject,
            TeacherID = homework.TeacherID
        };

        var check = _homeworkService.Create(homeworkDto);

        if (check)
            return Ok();
        else
            return BadRequest();
    }
}
