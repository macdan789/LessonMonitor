using System;

namespace LessonMonitor.WebAPI.Models;

public class Lesson
{
    public int LessonID { get; set; }
    public string LessonName { get; set; }
    public TimeSpan Duration { get; set; }
    public int TeacherID { get; set; }
}
