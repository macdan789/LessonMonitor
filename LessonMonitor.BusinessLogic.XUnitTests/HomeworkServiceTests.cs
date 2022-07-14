using AutoFixture;
using FluentAssertions;
using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.DBO;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.BusinessLogic.Exceptions;
using LessonMonitor.BusinessLogic.Services;
using Moq;

namespace LessonMonitor.BusinessLogic.XUnitTests;

public class HomeworkServiceTests
{
    private Guid _guidCtor;

    private readonly HomeworkService _homeworkService;
    private readonly Mock<IHomeworkRepository> _homeworkRepositoryMock;

    public static IEnumerable<object[]> Data => new List<object[]> 
    { 
        new object[] { -11 },
        new object[] { -12 },
        new object[] { -13 }
    };

    /*
     * Mechanism is creating new instance of Test class for each Test Method in our class,
     * so we have lifetime for instance in scope of one Test Method
     */
    public HomeworkServiceTests()
    {
        _guidCtor = Guid.NewGuid();
        Console.WriteLine($"{_guidCtor} Ctor");

        //arrange - всі загальні компоненти для тестів виносимо у конструктор
        _homeworkRepositoryMock = new Mock<IHomeworkRepository>();
        _homeworkService = new HomeworkService(_homeworkRepositoryMock.Object);
    }


    [Fact]
    public void Create_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        //via Constructor
        Fixture fixture = new Fixture();
        Homework homework = fixture.Build<Homework>().Create();

        // act - запускаємо метод для тесту
        var result = _homeworkService.Create(homework);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.NotNull(homework);
        _homeworkRepositoryMock.Verify(x => x.Create(It.IsAny<HomeworkDbo>()), Times.Once);

        //FluentAssertions
        homework.Should().NotBeNull();
    }

    //[Fact] = one test case without any method parameters.
    //[Theory] = can have multiple cases and take method arguments using [InlineData(value)] or [MemberData(nameof(Obj))] and others.

    [Theory]
    [InlineData(0)]
    [InlineData(-255)]
    [MemberData(nameof(Data))]
    public void Create_HomeworkIsInvalid_ThrowException(int teacherId)
    {
        //arrange
        Fixture fixture = new Fixture();
        Homework homework = fixture.Build<Homework>().With(x => x.TeacherID, teacherId).Create();
        bool result = false;

        //act
        var expectedException = Assert.Throws<BusinessException>(() => result = _homeworkService.Create(homework));

        //assert
        Assert.False(result);
        Assert.Equal("Property has invalid value.", expectedException.Message);

        //FluentAssertions
        result.Should().BeFalse();
        expectedException.Should().NotBeNull().And.Match<BusinessException>(x => x.Message == "Property has invalid value.");
    }


    [Fact]
    public void Update_HomeworkIsValid_Success()
    {
        // arrange - готуємо вхідні дані для тестування
        Homework homework = new Homework();

        // act - запускаємо метод для тесту
        var result = _homeworkService.Update(homework);

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.NotNull(homework);
        _homeworkRepositoryMock.Verify(x => x.Update(It.IsAny<HomeworkDbo>()), Times.Once);

        //FluentAssertions
        homework.Should().NotBeNull();
    }


    [Fact]
    public void Update_HomeworkIsNull_ThrowException()
    {
        // arrange - готуємо вхідні дані для тестування
        Homework homework = null;
        bool result = false;

        // act - запускаємо метод для тесту
        var expectedException = Assert.Throws<BusinessException>(() => result = _homeworkService.Update(homework));

        // assert - порівнюємо/валідуємо очікуваний та реальний результат
        Assert.Null(homework);
        Assert.NotNull(expectedException);
        Assert.Equal("Object is null.", expectedException.Message);

        //FluentAssertions
        homework.Should().BeNull();
        expectedException.Should().NotBeNull().And.Match<BusinessException>(x => x.Message == "Object is null.");
    }
}
