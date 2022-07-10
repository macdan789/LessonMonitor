using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;

namespace LessonMonitor.DAL.Repositories;

public class HomeworkRepository : IHomeworkRepository
{
    public bool Create(HomeworkDbo entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public HomeworkDbo Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<HomeworkDbo> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(HomeworkDbo entity)
    {
        throw new NotImplementedException();
    }
}
