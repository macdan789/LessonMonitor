using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.BusinessLogic.Service;

public class HomeworkService
{
    private readonly IHomeworkRepository _homeworkRepository;

    public HomeworkService(IHomeworkRepository homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }

    public HomeworkDto Create(string title, string subject, int teacherID)
    {
        var result = new HomeworkDto { Title = title, Subject = subject, TeacherID = teacherID };

        //Map from dto to dbo object
        var homeworkDbo = new HomeworkDbo { Title = title, Subject = subject, TeacherID = teacherID };

        //Save created dbo in database
        _homeworkRepository.Insert(homeworkDbo);

        return result;
    }
}
