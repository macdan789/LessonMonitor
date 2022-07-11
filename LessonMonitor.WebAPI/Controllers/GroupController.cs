using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupController : Controller
{
    private readonly IGroupService _service;

    public GroupController(IGroupService service)
    {
        _service = service;
    }


    [HttpGet("[action]/{groupID}")]
    public ActionResult<Group> GetGroup(int groupID)
    {
        var groupDto = _service.Get(groupID);

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
