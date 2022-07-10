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

    public bool Delete(HomeworkDto homeworkDto)
    {
        throw new NotImplementedException();
    }

    public HomeworkDto Get(HomeworkDto homeworkDto)
    {
        throw new NotImplementedException();
    }

    //!! operator will throw ArgumentNullException if parameter is NULL
    public bool Update(HomeworkDto homeworkDto!!)
    {
        //!! == below code
        //if(homeworkDto is null)
        //{
        //    throw new ArgumentNullException();
        //}

        //Mapping
        var homeworkDbo = new HomeworkDbo();

        var check = _homeworkRepository.Update(homeworkDbo);

        return true;
    }
}
