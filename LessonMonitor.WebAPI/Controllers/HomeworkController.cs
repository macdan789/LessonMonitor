using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeworkController : Controller
{
    private readonly IHomeworkService _service;

    public HomeworkController(IHomeworkService service)
    {
        _service = service;
    }


    [HttpGet()]
    [Route("[action]/{homeworkID}")]
    public ActionResult<Homework> GetHomework(int homeworkID)
    {
        var homeworkDto = _service.Get(homeworkID);

        //Mapping
        var result = new Homework
        {
            Subject = homeworkDto.Subject,
            Title = homeworkDto.Title,
            TeacherID = homeworkDto.TeacherID
        };

        return Ok(result);
    }
}
