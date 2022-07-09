using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;
using LessonMonitor.BusinessLogic.Service;

namespace LessonMonitor.BusinessLogic.MSTests;

[TestClass]
public class HomeworkServiceTests
{
    [TestMethod]
    public void Create_Homework_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        var homeworkRepositoryMock = new HomeworkRepositoryMock();
        var homeworkService = new HomeworkService(homeworkRepositoryMock);
        var title = "title value";
        var subject = "subject value";
        var teacherID = 1;

        // act - запускаємо метод для тесту
        var result = homeworkService.Create(title, subject, teacherID);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
    }
}

internal class HomeworkRepositoryMock : IHomeworkRepository
{
    public void Insert(HomeworkDbo homework)
    {
        Console.WriteLine("Object was saved in database.");
    }
}
