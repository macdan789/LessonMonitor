using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.WebAPI.Contracts.ApiRoutes;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers.V1;

[ApiController]
public class LessonController : Controller
{
    private readonly ILessonService _service;

    public LessonController(ILessonService service)
    {
        _service = service;
    }


    [HttpGet(ApiRoutes.Lesson.Get)]
    public ActionResult<Lesson> GetLesson(int lessonId)
    {
        return Ok();
    }
}
