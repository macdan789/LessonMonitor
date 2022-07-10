using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;

namespace LessonMonitor.DAL.Repositories;

public class GroupRepository : IGroupRepository
{
    public bool Create(GroupDbo entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int entityID)
    {
        throw new NotImplementedException();
    }

    public GroupDbo Get(int entityID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<GroupDbo> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Update(GroupDbo entity)
    {
        throw new NotImplementedException();
    }
}
