using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.AbstractCore.AbstractService;

public interface IHomeworkService
{
    bool Create(HomeworkDto homeworkDto);

    bool Update(HomeworkDto homeworkDto);

    HomeworkDto Get(HomeworkDto homeworkDto);

    bool Delete(HomeworkDto homeworkDto);
}
