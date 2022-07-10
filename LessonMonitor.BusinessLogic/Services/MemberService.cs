using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.DTO;

namespace LessonMonitor.BusinessLogic.Services;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _repository;

    public MemberService(IMemberRepository repository)
    {
        _repository = repository;
    }

    public bool Create(MemberDto entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public MemberDto Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<MemberDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(MemberDto entity)
    {
        throw new NotImplementedException();
    }
}
