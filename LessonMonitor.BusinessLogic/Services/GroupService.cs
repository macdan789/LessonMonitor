using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.Models.DTO;

namespace LessonMonitor.BusinessLogic.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _repository;

    public GroupService(IGroupRepository repository)
    {
        _repository = repository;
    }

    public bool Create(GroupDto entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public GroupDto Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<GroupDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(GroupDto entity)
    {
        throw new NotImplementedException();
    }
}
