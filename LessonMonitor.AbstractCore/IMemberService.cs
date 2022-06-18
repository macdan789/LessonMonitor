namespace LessonMonitor.AbstractCore;

public interface IMemberService
{
    T GetMember<T>(int memberID);
    void CreateMember(object member);
}
