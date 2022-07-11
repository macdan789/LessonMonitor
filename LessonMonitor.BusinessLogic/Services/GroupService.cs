using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.Presentation;

namespace LessonMonitor.BusinessLogic.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _repository;

    public GroupService(IGroupRepository repository)
    {
        _repository = repository;
    }

    public bool Create(Group entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public Group Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Group> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(Group entity)
    {
        throw new NotImplementedException();
    }
}
