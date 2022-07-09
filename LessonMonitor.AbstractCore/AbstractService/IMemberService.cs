using LessonMonitor.AbstractCore.DtoModel;

namespace LessonMonitor.AbstractCore.AbstractService;

public interface IMemberService
{
    MemberDto GetMember(int memberID);
}
