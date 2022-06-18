namespace LessonMonitor.AbstractCore;

public interface IMemberService
{
    object GetMember(int memberID);
    void CreateMember(object member);
}
