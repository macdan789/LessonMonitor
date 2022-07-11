using AutoFixture;
using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;
using LessonMonitor.AbstractCore.Models.DTO;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.BusinessLogic.Exceptions;
using LessonMonitor.BusinessLogic.Services;
using Moq;

namespace LessonMonitor.BusinessLogic.MSTests;

[TestClass]
public class HomeworkServiceTests
{
    private Guid _guidCtor;
    private Guid _guidInit;

    private readonly HomeworkService _homeworkService;
    private readonly Mock<IHomeworkRepository> _homeworkRepositoryMock;

    /*
     * Mechanism is creating new instance of Test class for each Test Method in our class,
     * so we have lifetime for instance in scope of one Test Method
     */
    public HomeworkServiceTests()
    {
        _guidCtor = Guid.NewGuid();
        Console.WriteLine($"{_guidCtor} Ctor");

        //arrange - всі загальні компоненти для тестів виносимо у конструктор або [TestInitialize] метод
        _homeworkRepositoryMock = new Mock<IHomeworkRepository>();
        _homeworkService = new HomeworkService(_homeworkRepositoryMock.Object);
    }

    [TestInitialize]
    public void Initialize()
    {
        _guidInit = Guid.NewGuid();
        Console.WriteLine($"{_guidInit} Initialize");
    }


    [TestMethod]
    public void CreateHomework_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        //via Constructor
        Fixture fixture = new Fixture();
        Homework homework = fixture.Build<Homework>().Create();

        // act - запускаємо метод для тесту
        var result = _homeworkService.Create(homework);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.IsNotNull(homework);
        _homeworkRepositoryMock.Verify(x => x.Create(It.IsAny<HomeworkDbo>()), Times.Once);
    }


    [TestMethod]
    public void CreateHomework_HomeworkIsInvalid_ThrowException()
    {
        //arrange
        Fixture fixture = new Fixture();
        Homework homework = fixture.Build<Homework>().Without(x => x.TeacherID).Create();
        bool result = false;

        //act
        var expectedException = Assert.ThrowsException<BusinessException>(() => result = _homeworkService.Create(homework));

        //assert
        Assert.IsFalse(result);
        Assert.AreEqual("Property has invalid value.", expectedException.Message);
    }


    [TestMethod]
    public void UpdateHomework_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        Homework homework = new Homework();

        // act - запускаємо метод для тесту
        var result = _homeworkService.Update(homework);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.IsNotNull(homework);
        _homeworkRepositoryMock.Verify(x => x.Update(It.IsAny<HomeworkDbo>()), Times.Once);
    }


    [TestMethod]
    public void UpdateHomework_HomeworkIsNull_ThrowException()
    {
        // arrange - готуємо вхідні дані для тестування
        Homework homework = null;
        bool result = false;

        // act - запускаємо метод для тесту
        var excpectedException = Assert.ThrowsException<BusinessException>(() => result = _homeworkService.Update(homework));

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.IsNull(homework);
        Assert.IsNotNull(excpectedException);
        Assert.AreEqual("Object is null.", excpectedException.Message);
    }
}
