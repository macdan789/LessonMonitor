using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonMonitor.DAL.Repositories;

public class TeacherRepository : ITeacherRepository
{
    public bool Create(TeacherDto entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public TeacherDto Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TeacherDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(TeacherDto entity)
    {
        throw new NotImplementedException();
    }
}
