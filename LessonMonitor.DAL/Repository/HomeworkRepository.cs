using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.DAL.Repository;

public class HomeworkRepository : IHomeworkRepository
{
    public bool Insert(HomeworkDbo homework)
    {
        //Do some logic to save object in database
        return true;
    }
}
