using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;

namespace LessonMonitor.BusinessLogic.Services;

public class LessonService : ILessonService
{
    private readonly ILessonRepository _repository;

    public LessonService(ILessonRepository repository)
    {
        _repository = repository;
    }

    public bool Create(Lesson entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public Lesson Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Lesson> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Lesson entity)
    {
        throw new NotImplementedException();
    }
}
