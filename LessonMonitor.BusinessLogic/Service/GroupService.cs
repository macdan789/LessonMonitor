using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.AbstractCore.DtoModel;

namespace LessonMonitor.BusinessLogic.Service;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _repository;

    public GroupService(IGroupRepository repository)
    {
        _repository = repository;
    }

    public GroupDto GetGroup(int groupID)
    {
        var groupDbo = _repository.GetGroup(groupID);
        var groupDto = new GroupDto();

        //Mapping to GroupDto model
        if (groupDbo is not null)
        {
            groupDto.GroupID = groupDbo.GroupID;
            groupDto.GroupName = groupDbo.GroupName;
            groupDto.MemberCount = groupDbo.MemberCount;
            groupDto.CuratorID = groupDbo.CuratorID;
        }

        return groupDto;
    }
}
