namespace LessonMonitor.WebAPI.Models;

public class Teacher
{
    public int TeacherID { get; set; }

    public int Age { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Group Group { get; set; }

    public string Specification { get; set; }
}
