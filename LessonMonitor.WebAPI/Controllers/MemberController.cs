using LessonMonitor.AbstractCore.AbstractServices;
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
    public ActionResult<Member> GetMember(int memberID)
    {
        var memberDto = _service.Get(memberID);

        //Mapping
        var result = new Member 
        { 
            MemberID = memberID, 
            FirstName = memberDto.FirstName,
            LastName = memberDto.LastName,
            EmailAddress = memberDto.EmailAddress,
            Age = memberDto.Age,
            GroupID = memberDto.GroupID
        };

        return Ok(result);
    }
}