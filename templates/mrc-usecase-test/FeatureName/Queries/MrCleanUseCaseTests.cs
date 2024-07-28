using MrClean.Common.Exceptions;
using MrClean.FeatureName.Queries.MrCleanUseCase;

namespace MrClean.FunctionalTests.FeatureName.Queries;

using static Testing;

public class MrCleanUseCaseTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireMinimumFields()
    {
        await ResetState();
        var userId = await RunAsDefaultUserAsync();

        var query = new MrCleanUseCaseQuery { };

        await FluentActions.Invoking(() => SendAsync(query))
            .Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldRequireAuthentication() 
    {
        await ResetState();

        var query = new MrCleanUseCaseQuery { };

        await FluentActions.Invoking(() => SendAsync(query))
            .Should().ThrowAsync<UnauthorizedAccessException>();
    }

    [Test]
    public async Task ShouldReturnValidResult() 
    {
        await ResetState();
        var userId = await RunAsDefaultUserAsync();

        var query = new MrCleanUseCaseQuery { };
        var result = await SendAsync(query);
        
        result.Should().NotBeNull();
    }
}