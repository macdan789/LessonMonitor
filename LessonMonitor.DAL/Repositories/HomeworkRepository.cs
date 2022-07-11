using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;

namespace LessonMonitor.DAL.Repositories;

public class HomeworkRepository : IHomeworkRepository
{
    public bool Create(HomeworkDbo entity)
    {
        //Do some logic to create new homework in database

        return true;
    }

    public bool Delete(int entityID)
    {
        //Do some logic to delete homework in database

        return true;
    }

    public HomeworkDbo Get(int entityID)
    {
        //Do some logic to get specific homework from database

        return new HomeworkDbo();
    }

    public IEnumerable<HomeworkDbo> GetAll()
    {
        //Do some logic to get all homeworks from database

        return Enumerable.Empty<HomeworkDbo>();
    }

    public bool Update(HomeworkDbo entity)
    {
        //Do some logic to update homework in database

        return true;
    }
}
