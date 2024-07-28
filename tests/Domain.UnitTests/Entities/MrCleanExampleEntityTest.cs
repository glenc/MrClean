using FluentAssertions;
using NUnit.Framework;
using MrClean.Domain.Entities;

namespace MrClean.Domain.UnitTests.Entities;

public class MrCleanExampleEntityTest
{
    [Test]
    public void CanCreateMrCleanExampleEntity()
    {
        var entity = new MrCleanExampleEntity();
        entity.Should().NotBeNull();
    }
}