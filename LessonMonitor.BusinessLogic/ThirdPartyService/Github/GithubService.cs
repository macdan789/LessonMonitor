using LessonMonitor.AbstractCore.ThirdPartyServices.GithubService;
using Octokit;

namespace LessonMonitor.BusinessLogic.ThirdPartyService.Github;

public class GithubService : IGithubService
{
    private readonly IGitHubClient _client;

    public GithubService()
    {
        _client = new GitHubClient(new ProductHeaderValue("LessonMonitor", "v1"));
    }

    public async Task<User> GetUser(string username)
    {
        var response = await _client.User.Get(username);
        return response;
    }

    public async Task<IEnumerable<Repository>> GetRepositoriesForUser(string username)
    {
        var response = await _client.Repository.GetAllForUser(username);
        return response;
    }
}
