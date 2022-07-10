using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;

namespace LessonMonitor.DAL.Repositories;

public class MemberRepository : IMemberRepository
{
    public bool Create(MemberDbo entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public MemberDbo Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<MemberDbo> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(MemberDbo entity)
    {
        throw new NotImplementedException();
    }
}
