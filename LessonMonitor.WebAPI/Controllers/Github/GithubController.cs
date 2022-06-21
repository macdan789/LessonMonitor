using LessonMonitor.AbstractCore.GithubService;
using LessonMonitor.BusinessLogic.Github;
using LessonMonitor.WebAPI.Mappers;
using LessonMonitor.WebAPI.Models.Github;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.Controllers.Github;

[ApiController]
[Route("api/[controller]")]
public class GithubController
{
    private readonly IGithubService service;

    public GithubController()
    {
        service = new GithubService();
    }

    [HttpGet("[action]/{username}")]
    public async Task<User> GetUser(string username)
    {
        var userDto = await service.GetUser(username);

        return userDto.MapUser();
    }
}
