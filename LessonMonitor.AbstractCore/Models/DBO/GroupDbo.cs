namespace LessonMonitor.AbstractCore.Models.DBO;

public class GroupDbo
{
    public int GroupID { get; set; }
    public string GroupName { get; set; }
    public int MemberCount { get; set; }
    public int CuratorID { get; set; }
}
