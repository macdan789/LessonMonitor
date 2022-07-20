using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.WebAPI.Contracts.ApiRoutes;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers.V1;

[ApiController]
public class GroupController : Controller
{
    private readonly IGroupService _service;

    public GroupController(IGroupService service)
    {
        _service = service;
    }


    [HttpGet(ApiRoutes.Group.Get)]
    public ActionResult<Group> GetGroup(int groupId)
    {
        return Ok();
    }
}
