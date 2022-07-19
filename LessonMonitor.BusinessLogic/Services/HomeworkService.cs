using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.DTO;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.BusinessLogic.Exceptions;

namespace LessonMonitor.BusinessLogic.Services;

public class HomeworkService : IHomeworkService
{
    private readonly IHomeworkRepository _repository;

    public HomeworkService(IHomeworkRepository repository)
    {
        _repository = repository;
    }

    public bool Create(Homework entity)
    {
        if (entity.TeacherID <= 0 || entity.TeacherID is null || string.IsNullOrEmpty(entity.Title) || string.IsNullOrEmpty(entity.Subject))
        {
            throw new BusinessException("Property has invalid value.");
        }

        //Mapping from presentation to dto
        HomeworkDto homeworkDto = new HomeworkDto();

        //Do some business logic about model

        //Mapping from dto to dbo
        HomeworkDto homeworkDbo = new HomeworkDto();

        bool isCreated = _repository.Create(homeworkDbo);  

        return isCreated;
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public Homework Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Homework> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Homework entity)
    {
        if(entity is null)
        {
            throw new BusinessException("Object is null.");
        }

        //Mapping from presentation to dto
        HomeworkDto homeworkDto = new HomeworkDto();

        //Do some business logic about model

        //Mapping from dto to dbo
        HomeworkDto homeworkDbo = new HomeworkDto();

        bool isUpdated = _repository.Update(homeworkDbo);

        return isUpdated;
    }
}
