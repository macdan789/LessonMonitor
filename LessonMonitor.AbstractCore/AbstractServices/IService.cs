namespace LessonMonitor.AbstractCore.AbstractServices;

public interface IService<T>
{
    T Get(int entityID);
    bool Update(T entity);
    bool Delete(int entityID);
    bool Create(T entity);
    IEnumerable<T> GetAll();

}
