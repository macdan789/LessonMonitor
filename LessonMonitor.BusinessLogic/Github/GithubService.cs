using LessonMonitor.AbstractCore.GithubService;
using Octokit;

namespace LessonMonitor.BusinessLogic.Github;

public class GithubService : IGithubService
{
    private readonly IGitHubClient client;

    public GithubService()
    {
        client = new GitHubClient(new ProductHeaderValue("LessonMonitor", "v1"));
    }

    public async Task<User> GetUser(string username)
    {
        var response = await client.User.Get(username);
        return response;
    }
}
