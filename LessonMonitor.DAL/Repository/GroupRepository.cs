using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.DAL.Model;

namespace LessonMonitor.DAL.Repository;

public class GroupRepository : IGroupRepository
{
    public object GetGroup(int groupID)
    {
        var group = new GroupEntity()
        {
            GroupID = 1,
            GroupName = "7-A",
            MemberCount = 30,
            CuratorID = 4
        };

        return group;
    }
}
