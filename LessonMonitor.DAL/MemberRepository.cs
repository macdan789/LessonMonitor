using LessonMonitor.AbstractCore;

namespace LessonMonitor.DAL;

public class MemberRepository : IMemberRepository
{
    public void CreateMember(object member)
    {
        throw new NotImplementedException();
    }

    public object GetMember(int memberID)
    {
        var member = new MemberEntity()
        {
            MemberID = 1,
            FirstName = "John",
            LastName = "Doe",
            Age = 20
        };

        return member;
    }
}
