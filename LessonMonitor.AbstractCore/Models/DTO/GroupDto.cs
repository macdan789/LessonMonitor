namespace LessonMonitor.AbstractCore.Models.DTO;

public class GroupDto
{
    public int GroupID { get; set; }
    public string GroupName { get; set; }
    public int MemberCount { get; set; }
    public int CuratorID { get; set; }
}
