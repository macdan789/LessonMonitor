using LessonMonitor.AbstractCore;
using LessonMonitor.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonMonitor.BusinessLogic;

public class MemberService : IMemberService
{
    private readonly IMemberRepository repository;

    public MemberService()
    {
        repository = new MemberRepository();
    }

    public void CreateMember(object member)
    {
        repository.CreateMember(member);

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
