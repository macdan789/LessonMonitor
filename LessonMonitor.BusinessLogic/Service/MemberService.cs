using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.AbstractCore.DtoModel;

namespace LessonMonitor.BusinessLogic.Service;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _repository;

    public MemberService(IMemberRepository repository)
    {
        _repository = repository;
    }

    public MemberDto GetMember(int memberID)
    {
        var memberDbo = _repository.GetMember(memberID);
        var memberDto = new MemberDto();

        //Mapping to MemberDto model
        if (memberDbo is not null)
        {
            memberDto.MemberID = memberDbo.MemberID;
            memberDto.FirstName = memberDbo.FirstName;
            memberDto.LastName = memberDbo.LastName;
            memberDto.Age = memberDbo.Age;
        }

        return memberDto;
    }
}
