using LessonMonitor.AbstractCore.Abstract;
using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.BusinessLogic.Model;
using LessonMonitor.DAL.Model;
using LessonMonitor.DAL.Repository;

namespace LessonMonitor.BusinessLogic.Service;

public class MemberService : IMemberService
{
    private readonly IMemberRepository repository;

    public MemberService()
    {
        repository = new MemberRepository();
    }

    public object GetMember(int memberID)
    {
        var memberEntity = repository.GetMember(memberID) as MemberEntity;
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
