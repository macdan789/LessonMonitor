using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.BusinessLogic.Service;

public class HomeworkService : IHomeworkService
{
    private readonly IHomeworkRepository _homeworkRepository;

    public HomeworkService(IHomeworkRepository homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }

    public bool Create(HomeworkDto homeworkDto) 
    {
        //Save created dbo in database
        var check = _homeworkRepository.Insert(new HomeworkDbo());

        return check;
    }
}
