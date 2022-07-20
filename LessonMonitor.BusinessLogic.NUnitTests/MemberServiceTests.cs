using FluentAssertions;
using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.Models.Presentation;
using LessonMonitor.BusinessLogic.Exceptions;
using LessonMonitor.BusinessLogic.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonMonitor.BusinessLogic.NUnitTests;

internal class MemberServiceTests
{
    private MemberService _service;
    private Mock<IMemberRepository> _mockRepository;

    [SetUp]
    public void SetUp()
    {
        //Calls each time for each test method
        _mockRepository = new Mock<IMemberRepository>();
        _service = new MemberService(_mockRepository.Object);
    }

    [Test]
    public void Get_IdIsValid_ValidMember()
    {
        //arrange
        var memberId = new Random().Next(1, 1000);

        //act
        var member = _service.Get(memberId);

        //assert
        Assert.That(memberId, Is.InRange(1, 1000));
        Assert.That(member, Is.Not.Null);

        memberId.Should().BeInRange(1, 1000);
        member.Should().NotBeNull(because: "memberId is valid");
    }

    [Test]
    public void Get_IdIsInValid_NullValue()
    {
        //arrange
        var memberId = new Random().Next(-1000, 0);
        Member member = null;

        //act
        member = _service.Get(memberId);

        //assert
        Assert.That(memberId, Is.InRange(-1000, 0));
        Assert.That(member, Is.Null);

        memberId.Should().BeInRange(-1000, 0);
        member.Should().BeNull();
    }
}
