using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;

namespace LessonMonitor.DAL.Repositories;

public class LessonRepository : ILessonRepository
{
    public bool Create(LessonDbo entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public LessonDbo Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<LessonDbo> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(LessonDbo entity)
    {
        throw new NotImplementedException();
    }
}
