namespace LessonMonitor.AbstractCore;

public interface IMemberRepository
{
    object GetMember(int memberID);
    void CreateMember(object member);

}
