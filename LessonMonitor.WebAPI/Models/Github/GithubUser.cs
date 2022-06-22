using System;

namespace LessonMonitor.WebAPI.Models.Github;

public class GithubUser
{
    public string Bio { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Username { get; set; }
    public string RealName { get; set; }
    public string Location { get; set; }
}
