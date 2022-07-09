using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.AbstractCore.AbstractRepository;

public interface IHomeworkRepository
{
    bool Insert(HomeworkDbo homework);
}
