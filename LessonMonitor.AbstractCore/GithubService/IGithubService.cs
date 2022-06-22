using Octokit;

namespace LessonMonitor.AbstractCore.GithubService;

public interface IGithubService
{
    Task<User> GetUser(string username);
    Task<IEnumerable<Repository>> GetRepositoriesForUser(string username);
}
