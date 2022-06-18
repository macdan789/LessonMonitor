using LessonMonitor.WebAPI.Attributes;

namespace LessonMonitor.WebAPI.Models;

public class Member
{
    public int MemberID { get; set; }

    public int Age { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}