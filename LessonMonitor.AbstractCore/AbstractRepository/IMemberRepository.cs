using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.AbstractCore.AbstractRepository;

public interface IMemberRepository
{
    MemberDbo GetMember(int memberID);

}
