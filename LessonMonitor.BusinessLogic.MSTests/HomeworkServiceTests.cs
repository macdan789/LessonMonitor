using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;
using LessonMonitor.BusinessLogic.Service;
using Moq;

namespace LessonMonitor.BusinessLogic.MSTests;

[TestClass]
public class HomeworkServiceTests
{
    [TestMethod]
    public void Create_Homework_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        var custom_homeworkRepositoryMock = new HomeworkRepositoryMock();
        var homeworkRepositoryMock = new Mock<IHomeworkRepository>();

        var homeworkService = new HomeworkService(homeworkRepositoryMock.Object);

        // act - запускаємо метод для тесту
        var result = homeworkService.Create(new HomeworkDto());

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        homeworkRepositoryMock.Verify(x => x.Insert(It.IsAny<HomeworkDbo>()), Times.Once);
    }
}

//Mock object - is a fake item that implements logic of main object
internal class HomeworkRepositoryMock : IHomeworkRepository
{
    public bool Insert(HomeworkDbo homework)
    {
        Console.WriteLine("Object was saved in database.");
        return true;
    }
}
