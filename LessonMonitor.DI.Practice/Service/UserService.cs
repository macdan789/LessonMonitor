using LessonMonitor.DI.Practice.Helpers;

namespace LessonMonitor.DI.Practice.Service;

public class UserService : IUserService
{
    private readonly IGithubClient _githubClient;
    private Guid _guid;

    public UserService(IGithubClient githubClient)
    {
        _guid = Guid.NewGuid();
        _githubClient = githubClient;
    }

    public void GetGuid()
    {
        Console.WriteLine(nameof(UserService) + " | " + _guid);
        _githubClient.GetGuid();
    }
}
