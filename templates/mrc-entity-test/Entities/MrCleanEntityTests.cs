using FluentAssertions;
using NUnit.Framework;
using MrClean.Common;
using MrClean.Entities;

namespace MrClean.UnitTests.Entities;

public class MrCleanEntityTests
{
    [Test]
    public void CanCreateMrCleanEntity()
    {
        var entity = new MrCleanEntity();
        entity.Should().NotBeNull();
    }
}