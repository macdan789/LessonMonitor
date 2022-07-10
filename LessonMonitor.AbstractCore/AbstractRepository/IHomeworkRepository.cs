using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.AbstractCore.AbstractRepository;

public interface IHomeworkRepository
{
    bool Insert(HomeworkDbo homework);

    bool Update(HomeworkDbo homework);

    HomeworkDbo Get(HomeworkDbo homework);

    bool Delete(HomeworkDbo homework);
}
