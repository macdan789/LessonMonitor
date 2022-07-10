using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.DAL.Repository;

public class HomeworkRepository : IHomeworkRepository
{
    public bool Delete(HomeworkDbo homework)
    {
        //Do some logic to delete object in database
        return true;
    }

    public HomeworkDbo Get(HomeworkDbo homework)
    {
        //Do some logic to get object from database
        return new HomeworkDbo();
    }

    public bool Insert(HomeworkDbo homework)
    {
        //Do some logic to save object in database
        return true;
    }

    public bool Update(HomeworkDbo homework)
    {
        //Do some logic to update object in database
        return true;
    }
}
