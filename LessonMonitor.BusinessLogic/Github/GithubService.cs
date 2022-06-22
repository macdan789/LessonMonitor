using LessonMonitor.AbstractCore.GithubService;
using Octokit;

namespace LessonMonitor.BusinessLogic.Github;

public class GithubService : IGithubService
{
    private readonly IGitHubClient _client;

    public GithubService(GitHubClient client)
    {
        _client = client;
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
