namespace LessonMonitor.DI.Practice.Helpers;

public class GithubClient : IGithubClient
{
    private Guid _guid;

    public GithubClient()
    {
        _guid = Guid.NewGuid();
    }

    public void GetGuid()
        => Console.WriteLine(nameof(GithubClient) + " | " + _guid);
}
