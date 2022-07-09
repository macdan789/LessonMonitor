using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MemberController : ControllerBase
{
    private readonly IMemberService _service;

    public MemberController(IMemberService service)
    {
        _service = service;
    }

    [HttpGet("[action]/{memberID}")]
    public IActionResult GetMember(int memberID)
    {
        var memberDto = _service.GetMember(memberID);
        var result = new Member();

        //Mapping to Member model
        if (memberDto is not null)
        {
            result.MemberID = memberDto.MemberID;
            result.FirstName = memberDto.FirstName;
            result.LastName = memberDto.LastName;
            result.Age = memberDto.Age;
        }

        return Ok(result);
    }
}