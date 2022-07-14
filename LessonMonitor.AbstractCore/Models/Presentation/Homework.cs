using System.ComponentModel.DataAnnotations;

namespace LessonMonitor.AbstractCore.Models.Presentation;

public class Homework
{
    public string Title { get; set; }
    public string Subject { get; set; }
    public int? TeacherID { get; set; }
}
