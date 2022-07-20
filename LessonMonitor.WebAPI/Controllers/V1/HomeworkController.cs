using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.WebAPI.Contracts.ApiRoutes;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers.V1;

[ApiController]
public class HomeworkController : Controller
{
    private readonly IHomeworkService _service;

    public HomeworkController(IHomeworkService service)
    {
        _service = service;
    }


    [HttpGet(ApiRoutes.Homework.Get)]
    public ActionResult<Homework> GetHomework(int homeworkId)
    {
        return Ok();
    }
}
