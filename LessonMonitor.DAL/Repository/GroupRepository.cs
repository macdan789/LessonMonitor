using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.DAL.Repository;

public class GroupRepository : IGroupRepository
{
    public GroupDbo GetGroup(int groupID)
    {
        var group = new GroupDbo()
        {
            GroupID = 1,
            GroupName = "7-A",
            MemberCount = 30,
            CuratorID = 4
        };

        return group;
    }
}
