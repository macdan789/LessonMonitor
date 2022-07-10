using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.DboModel;
using LessonMonitor.BusinessLogic.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LessonMonitor.BusinessLogic.MSTests;

[TestClass]
public class HomeworkServiceTests
{
    [TestMethod]
    public void Create_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        var homeworkRepositoryMock = new Mock<IHomeworkRepository>();

        var homeworkService = new HomeworkService(homeworkRepositoryMock.Object);

        // act - запускаємо метод для тесту
        var result = homeworkService.Create(new HomeworkDto());

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        homeworkRepositoryMock.Verify(x => x.Insert(It.IsAny<HomeworkDbo>()), Times.Once);
    }


    [TestMethod]
    public void Update_HomeworkIsNull_ThrowException()
    {
        // arrange - готуємо вхідні дані для тестування
        var homeworkRepositoryMock = new Mock<IHomeworkRepository>();
        var homeworkService = new HomeworkService(homeworkRepositoryMock.Object);
        HomeworkDto homeworkDto = null;
        bool result = false;

        // act - запускаємо метод для тесту
        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.IsNull(homeworkDto);
        Assert.ThrowsException<ArgumentNullException>(() => result = homeworkService.Update(homeworkDto));
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Update_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        var homeworkRepositoryMock = new Mock<IHomeworkRepository>();
        var homeworkService = new HomeworkService(homeworkRepositoryMock.Object);
        HomeworkDto homeworkDto = new HomeworkDto();
        bool result = false;

        // act - запускаємо метод для тесту
        result = homeworkService.Update(homeworkDto);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.IsNotNull(homeworkDto);
        Assert.IsTrue(result);
    }

}
