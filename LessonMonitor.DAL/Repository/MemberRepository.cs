using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.DAL.Repository;

public class MemberRepository : IMemberRepository
{

    public MemberDbo GetMember(int memberID)
    {
        var member = new MemberDbo()
        {
            MemberID = 1,
            FirstName = "John",
            LastName = "Doe",
            Age = 20
        };

        return member;
    }
}
