using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.AbstractCore.DboModel;
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
    public IActionResult CreateHomework([FromBody] HomeworkDto homeworkDto)
    {
        var check = _homeworkService.Create(homeworkDto);

        if (check)
            return Ok();
        else
            return BadRequest();
    }
}
