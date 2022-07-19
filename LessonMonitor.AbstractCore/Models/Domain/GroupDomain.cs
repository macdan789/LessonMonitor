namespace LessonMonitor.AbstractCore.Models.Domain;

public class GroupDomain
{
    public int GroupID { get; set; }
    public string GroupName { get; set; }
    public int MemberCount { get; set; }
    public int CuratorID { get; set; }
}
