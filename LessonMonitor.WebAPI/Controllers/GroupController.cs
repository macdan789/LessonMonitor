using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.WebAPI.Contracts.ApiRoutes;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

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
        var groupDto = _service.Get(groupId);

        //Mapping
        var result = new Group
        {
            GroupID = groupDto.GroupID,
            GroupName = groupDto.GroupName,
            MemberCount = groupDto.MemberCount,
            CuratorID = groupDto.CuratorID
        };

        return Ok(result);
    }
}
