using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;

namespace LessonMonitor.BusinessLogic.Services;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _repository;

    public MemberService(IMemberRepository repository)
    {
        _repository = repository;
    }

    public bool Create(Member entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public Member Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Member> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Member entity)
    {
        throw new NotImplementedException();
    }
}
