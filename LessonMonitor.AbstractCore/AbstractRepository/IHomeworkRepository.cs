using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.AbstractCore.AbstractRepository;

public interface IHomeworkRepository
{
    void Insert(HomeworkDbo homework);
}
