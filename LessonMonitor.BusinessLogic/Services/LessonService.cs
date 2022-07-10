using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.DTO;

namespace LessonMonitor.BusinessLogic.Services;

public class LessonService : ILessonService
{
    private readonly ILessonRepository _repository;

    public LessonService(ILessonRepository repository)
    {
        _repository = repository;
    }

    public bool Create(LessonDto entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public LessonDto Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<LessonDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(LessonDto entity)
    {
        throw new NotImplementedException();
    }
}
