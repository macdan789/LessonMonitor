namespace LessonMonitor.AbstractCore.Models.Presentation;

public class Group
{
    public int GroupID { get; set; }
    public string GroupName { get; set; }
    public int MemberCount { get; set; }
    public int CuratorID { get; set; }
}
