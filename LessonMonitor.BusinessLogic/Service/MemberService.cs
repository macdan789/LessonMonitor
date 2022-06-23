using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.BusinessLogic.Model;
using LessonMonitor.DAL.Model;
using LessonMonitor.DAL.Repository;

namespace LessonMonitor.BusinessLogic.Service;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _repository;

    public MemberService(IMemberRepository repository)
    {
        _repository = repository;
    }

    public object GetMember(int memberID)
    {
        var memberEntity = _repository.GetMember(memberID) as MemberEntity;
        var memberDto = new MemberDto();

        //Mapping to MemberDto model
        if (memberEntity is not null)
        {
            memberDto.MemberID = memberEntity.MemberID;
            memberDto.FirstName = memberEntity.FirstName;
            memberDto.LastName = memberEntity.LastName;
            memberDto.Age = memberEntity.Age;
        }

        return memberDto;
    }
}
