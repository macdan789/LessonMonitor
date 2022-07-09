using LessonMonitor.DI.Practice.Helpers;

namespace LessonMonitor.DI.Practice.Service;

public class RepositoryService : IRepositoryService
{
    private readonly IGithubClient _client;
    private Guid _guid;

    public RepositoryService(IGithubClient client)
    {
        _client = client;
    }

    public void GetGuid()
    {
        Console.WriteLine(nameof(RepositoryService) + " | " + _guid);
        _client.GetGuid();
    }
}
