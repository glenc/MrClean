using MrClean.Common.Exceptions;
using MrClean.FeatureName.Commands.MrCleanUseCase;

namespace MrClean.FunctionalTests.FeatureName.Commands;

using static Testing;

public class MrCleanUseCaseTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireMinimumFields()
    {
        await ResetState();
        var userId = await RunAsDefaultUserAsync();

        var command = new MrCleanUseCaseCommand { };

        await FluentActions.Invoking(() => SendAsync(command))
            .Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldRequireAuthentication() 
    {
        await ResetState();

        var command = new MrCleanUseCaseCommand { };

        await FluentActions.Invoking(() => SendAsync(command))
            .Should().ThrowAsync<UnauthorizedAccessException>();
    }

    [Test]
    public async Task ShouldReturnId()
    {
        await ResetState();
        var userId = await RunAsDefaultUserAsync();

        var command = new MrCleanUseCaseCommand { };
        var result = await SendAsync(command);
        
        result.Should().BePositive();
    }
}