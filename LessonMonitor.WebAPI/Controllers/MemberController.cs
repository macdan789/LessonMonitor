using LessonMonitor.BusinessLogic.Service;
using LessonMonitor.BusinessLogic.Model;
using LessonMonitor.DAL;
using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using LessonMonitor.AbstractCore.Abstract;

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
        var memberDto = service.GetMember(memberID) as MemberDto;
        var result = new Member();
        
        //Mapping to Member model
        if(memberDto is not null)
        {
            result.MemberID = memberDto.MemberID;
            result.FirstName = memberDto.FirstName;
            result.LastName = memberDto.LastName;
            result.Age = memberDto.Age;
        }

        return Ok(result);
    }
}