using LessonMonitor.AbstractCore.ThirdPartyServices.GithubService;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.Controllers.Github;

[ApiController]
[Route("api/[controller]")]
public class GithubController
{
    private readonly IGithubService _service;

    public GithubController(IGithubService service)
    {
        _service = service;
    }


    [HttpGet("[action]/{username}")]
    public async Task<User> GetUser(string username)
    {
        var userDto = await _service.GetUser(username);

        return userDto;
    }


    [HttpGet("[action]/{username}")]
    public async Task<IEnumerable<Repository>> GetRepositories(string username)
    {
        var repositoriesDto = await _service.GetRepositoriesForUser(username);

        return repositoriesDto;
    }
}
