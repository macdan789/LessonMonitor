using LessonMonitor.WebAPI.Models.Github;
using System;

namespace LessonMonitor.WebAPI.Mappers;

public static class GithubUserMapper
{
    public static User MapUser(this Octokit.User input) => new User()
    {
        Bio = input.Bio,
        CreatedAt = input.CreatedAt.DateTime,
        Email = input.Email,
        RealName = input.Name,
        Username = input.Login,
        Location = input.Location
    };
}
