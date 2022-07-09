using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.AbstractCore.AbstractService;

public interface IHomeworkService
{
    bool Create(HomeworkDto homeworkDto);
}
