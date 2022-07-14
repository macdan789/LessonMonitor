using AutoFixture;
using FluentAssertions;
using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.BusinessLogic.Exceptions;
using LessonMonitor.BusinessLogic.Services;
using Moq;

namespace LessonMonitor.BusinessLogic.NUnitTests;

public class HomeworkServiceTests
{
    private Guid _guidSetUp;
    private Guid _guidCtor;

    private HomeworkService _homeworkService;
    private Mock<IHomeworkRepository> _homeworkRepositoryMock;


    public HomeworkServiceTests()
    {
        _guidCtor = Guid.NewGuid();
    }


    [SetUp]
    public void SetUp()
    {
        _guidSetUp = Guid.NewGuid();
        Console.WriteLine($"{_guidSetUp} SetUp");

        //arrange - всі загальні компоненти для тестів виносимо у [SetUp] метод
        _homeworkRepositoryMock = new Mock<IHomeworkRepository>();
        _homeworkService = new HomeworkService(_homeworkRepositoryMock.Object);
    }


    [Test]
    public void Create_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        //via Constructor
        Fixture fixture = new Fixture();
        Homework homework = fixture.Build<Homework>().Create();

        // act - запускаємо метод для тесту
        var result = _homeworkService.Create(homework);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.That(homework, Is.Not.Null);
        _homeworkRepositoryMock.Verify(x => x.Create(It.IsAny<HomeworkDbo>()), Times.Once);

        //FluentAssertions
        homework.Should().NotBeNull();
    }


    [TestCase(0)]
    [TestCase(-10)]
    [TestCase(-1050)]
    public void Create_HomeworkIsInvalid_ThrowException(int teacherId)
    {
        //arrange
        Fixture fixture = new Fixture();
        Homework homework = fixture.Build<Homework>().With(x => x.TeacherID, teacherId).Create();
        bool result = false;

        //act
        var expectedException = Assert.Throws<BusinessException>(() => result = _homeworkService.Create(homework));

        //assert
        Assert.That(result, Is.False);
        Assert.That(expectedException.Message, Is.EqualTo("Property has invalid value."));

        //FluentAssertions
        result.Should().BeFalse();
        expectedException.Should().NotBeNull().And.Match<BusinessException>(x => x.Message == "Property has invalid value.");
    }


    [Test]
    public void Update_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        Homework homework = new Homework();

        // act - запускаємо метод для тесту
        var result = _homeworkService.Update(homework);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.That(homework, Is.Not.Null);
        _homeworkRepositoryMock.Verify(x => x.Update(It.IsAny<HomeworkDbo>()), Times.Once);

        //FluentAssertions
        homework.Should().NotBeNull();
    }


    [Test]
    public void Update_HomeworkIsNull_ThrowException()
    {
        // arrange - готуємо вхідні дані для тестування
        Homework homework = null;
        bool result = false;

        // act - запускаємо метод для тесту
        var expectedException = Assert.Throws<BusinessException>(() => result = _homeworkService.Update(homework));

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.That(homework, Is.Null);
        Assert.That(expectedException, Is.Not.Null);
        Assert.That(expectedException.Message, Is.EqualTo("Object is null."));

        //FluentAssertions
        homework.Should().BeNull();
        expectedException.Should().NotBeNull().And.Match<BusinessException>(x => x.Message == "Object is null.");
    }
}
