using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.WebAPI.Contracts.ApiRoutes;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers.V1;

[ApiController]
public class MemberController : ControllerBase
{
    private readonly IMemberService _service;

    public MemberController(IMemberService service)
    {
        _service = service;
    }


    [HttpGet(ApiRoutes.Member.Get)]
    public ActionResult<Member> GetMember(int memberId)
    {
        return Ok();
    }
}