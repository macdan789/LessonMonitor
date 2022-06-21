using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.DAL.Model;

namespace LessonMonitor.DAL.Repository;

public class MemberRepository : IMemberRepository
{

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
