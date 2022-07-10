using AutoFixture;
using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Exceptions;
using LessonMonitor.AbstractCore.Models.DBO;
using LessonMonitor.AbstractCore.Models.DTO;
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


    [TestCleanup]
    [TestMethod]
    public void CreateHomework_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        //via Constructor

        // act - запускаємо метод для тесту
        var result = _homeworkService.Create(new HomeworkDto { Subject = "subject", Title = "title", TeacherID = 111 });

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        _homeworkRepositoryMock.Verify(x => x.Create(It.IsAny<HomeworkDbo>()), Times.Once);
    }


    [TestCleanup]
    [TestMethod]
    public void UpdateHomework_HomeworkIsNull_ThrowException()
    {
        // arrange - готуємо вхідні дані для тестування
        HomeworkDto homeworkDto = null;
        bool result = false;

        // act - запускаємо метод для тесту
        var excpectedException = Assert.ThrowsException<ArgumentNullException>(() => result = _homeworkService.Update(homeworkDto));

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.IsNull(homeworkDto);
        Assert.IsFalse(result);
        Assert.IsNotNull(excpectedException);
    }


    [TestCleanup]
    [TestMethod]
    public void UpdateHomework_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        HomeworkDto homeworkDto = new HomeworkDto();

        // act - запускаємо метод для тесту
        var result = _homeworkService.Update(homeworkDto);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.IsNotNull(homeworkDto);
        Assert.IsTrue(result);
    }


    [TestCleanup]
    [TestMethod]
    public void CreateHomework_HomeworkIsInvalid_ThrowException()
    {
        //arrange
        var fixture = new Fixture();
        var homework = fixture.Build<HomeworkDto>()
            .Without(x => x.TeacherID)
            .Create();

        bool result = false;

        //act
        var expectedException = Assert.ThrowsException<BusinessException>(() => result = _homeworkService.Create(homework));

        //assert
        Assert.IsFalse(result);
        Assert.AreEqual("Property has invalid value.", expectedException.Message);
    }
}
