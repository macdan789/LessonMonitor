using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DTO;

namespace LessonMonitor.DAL.Repositories;

public class LessonRepository : ILessonRepository
{
    public bool Create(LessonDto entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public LessonDto Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<LessonDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(LessonDto entity)
    {
        throw new NotImplementedException();
    }
}
