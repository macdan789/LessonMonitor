using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LessonController : Controller
{
    private readonly ILessonService _service;

    public LessonController(ILessonService service)
    {
        _service = service;
    }


    [HttpGet("[action]/{lessonID}")]
    public ActionResult<Lesson> GetLesson(int lessonID)
    {
        var lessonDto = _service.Get(lessonID);

        //Mapping
        var result = new Lesson
        {
            LessonID = lessonDto.LessonID,
            LessonName = lessonDto.LessonName,
            Duration = lessonDto.Duration,
            TeacherID = lessonDto.TeacherID
        };

        return Ok(result);
    }
}
