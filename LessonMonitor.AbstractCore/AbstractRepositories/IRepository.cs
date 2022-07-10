namespace LessonMonitor.AbstractCore.AbstractRepositories;

public interface IRepository<T>
{
    T Get(int entityID);
    bool Update(T entity);
    bool Delete(int entityID);
    bool Create(T entity);
    IEnumerable<T> GetAll();
}
