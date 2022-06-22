﻿using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.BusinessLogic.Model;
using LessonMonitor.BusinessLogic.Service;
using LessonMonitor.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupController : Controller
{
    private readonly IGroupService service;

    public GroupController()
    {
        service = new GroupService();
    }

    [HttpGet("[action]/{groupID}")]
    public IActionResult GetGroup(int groupID)
    {
        var groupDto = service.GetGroup(groupID) as GroupDto;
        var result = new Group();

        //Mapping to Group model
        if (groupDto is not null)
        {
            result.GroupID = groupDto.GroupID;
            result.GroupName = groupDto.GroupName;
            result.MemberCount = groupDto.MemberCount;
            result.CuratorID = groupDto.CuratorID;
        }

        return Ok(result);
    }
}