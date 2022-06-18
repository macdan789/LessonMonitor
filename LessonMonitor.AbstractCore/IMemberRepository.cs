namespace LessonMonitor.AbstractCore;

public interface IMemberRepository
{
    public object GetMember(int memberID);
    public void CreateMember(object member);

}
