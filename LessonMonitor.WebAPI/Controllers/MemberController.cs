using LessonMonitor.AbstractCore;
using LessonMonitor.BusinessLogic;
using LessonMonitor.DAL;
using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MemberController : ControllerBase
{
    private readonly IMemberService service;

    public MemberController()
    {
        service = new MemberService();
    }
    
    [HttpGet("[action]/{memberID}")]
    public IActionResult GetMember(int memberID)
    {
        var result = service.GetMember(memberID);
        return Ok();
    }


    [HttpPost("[action]")]
    public IActionResult CreateMember([FromBody] Member member)
    {
        service.CreateMember(member);
        return Ok();
    }
}