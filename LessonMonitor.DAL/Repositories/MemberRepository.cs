﻿using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DTO;

namespace LessonMonitor.DAL.Repositories;

public class MemberRepository : IMemberRepository
{
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
