using LessonMonitor.AbstractCore.DtoModel;

namespace LessonMonitor.AbstractCore.AbstractService;

public interface IGroupService
{
    GroupDto GetGroup(int groupID);
}
