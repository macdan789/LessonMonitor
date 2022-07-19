using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DTO;

namespace LessonMonitor.DAL.Repositories;

public class HomeworkRepository : IHomeworkRepository
{
    public bool Create(HomeworkDto entity)
    {
        //Do some logic to create new homework in database

        return true;
    }

    public bool Delete(int entityID)
    {
        //Do some logic to delete homework in database

        return true;
    }

    public HomeworkDto Get(int entityID)
    {
        //Do some logic to get specific homework from database

        return new HomeworkDto();
    }

    public IEnumerable<HomeworkDto> GetAll()
    {
        //Do some logic to get all homeworks from database

        return Enumerable.Empty<HomeworkDto>();
    }

    public bool Update(HomeworkDto entity)
    {
        //Do some logic to update homework in database

        return true;
    }
}
