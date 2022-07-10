using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.DTO;

namespace LessonMonitor.BusinessLogic.Services;

public class HomeworkService : IHomeworkService
{
    private readonly IHomeworkRepository _repository;

    public HomeworkService(IHomeworkRepository repository)
    {
        _repository = repository;
    }

    public bool Create(HomeworkDto entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public HomeworkDto Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<HomeworkDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(HomeworkDto entity)
    {
        throw new NotImplementedException();
    }
}
