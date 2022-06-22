using LessonMonitor.WebAPI.Models.Github;

namespace LessonMonitor.WebAPI.Mappers;

public static class GithubUserMapper
{
    public static GithubUser MapUser(this Octokit.User input) => new()
    {
        Bio = input.Bio,
        CreatedAt = input.CreatedAt.DateTime,
        Email = input.Email,
        RealName = input.Name,
        Username = input.Login,
        Location = input.Location
    };
}
