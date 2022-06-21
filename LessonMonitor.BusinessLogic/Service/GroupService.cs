using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.BusinessLogic.Model;
using LessonMonitor.DAL.Model;
using LessonMonitor.DAL.Repository;

namespace LessonMonitor.BusinessLogic.Service;

public class GroupService : IGroupService
{
    private readonly IGroupRepository repository;

    public GroupService()
    {
        repository = new GroupRepository();
    }

    public object GetGroup(int groupID)
    {
        var groupEntity = repository.GetGroup(groupID) as GroupEntity;
        var groupDto = new GroupDto();

        //Mapping to GroupDto model
        if (groupEntity is not null)
        {
            groupDto.GroupID = groupEntity.GroupID;
            groupDto.GroupName = groupEntity.GroupName;
            groupDto.MemberCount = groupEntity.MemberCount;
            groupDto.CuratorID = groupEntity.CuratorID;
        }

        return groupDto;
    }
}
