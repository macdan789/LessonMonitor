namespace LessonMonitor.AbstractCore.Models.DBO;

public class LessonDbo
{
    public int LessonID { get; set; }
    public string LessonName { get; set; }
    public TimeSpan Duration { get; set; }
    public int TeacherID { get; set; }
}
