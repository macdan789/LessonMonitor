using LessonMonitor.AbstractCore.GithubService;
using LessonMonitor.BusinessLogic.Github;
using LessonMonitor.WebAPI.Mappers;
using LessonMonitor.WebAPI.Models.Github;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LessonMonitor.WebAPI.Controllers.Github;

[ApiController]
[Route("api/[controller]")]
public class GithubController
{
    private readonly IGithubService service;

    public GithubController()
    {
        var client = new GitHubClient(new ProductHeaderValue("LessonMonitor", "v1"));
        service = new GithubService(client);
    }

    [HttpGet("[action]/{username}")]
    public async Task<GithubUser> GetUser(string username)
    {
        var userDto = await service.GetUser(username);

        return userDto.MapUser();
    }

    [HttpGet("[action]/{username}")]
    public async Task<IEnumerable<Repository>> GetRepositoriesForUser(string username)
    {
        var repositoriesDto = await service.GetRepositoriesForUser(username);

        return repositoriesDto;
    }
}
