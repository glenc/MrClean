using MrClean.Common.Interfaces;
using MrClean.Common.Security;

namespace MrClean.FeatureName.Commands.MrCleanUseCase;

public record MrCleanUseCaseCommand : IRequest<ReturnType>
{
    public string Name { get; init; } = "";
}

public class MrCleanUseCaseCommandValidator : AbstractValidator<MrCleanUseCaseCommand>
{
    public MrCleanUseCaseCommandValidator()
    {

    }
}

public class MrCleanUseCaseCommandHandler : IRequestHandler<MrCleanUseCaseCommand, ReturnType>
{
    private readonly IApplicationDbContext _context;
    private readonly IUser _user;

    public MrCleanUseCaseCommandHandler(IApplicationDbContext context, IUser user)
    {
        _context = context;
        _user = user;
    }

    public async Task<ReturnType> Handle(MrCleanUseCaseCommand request, CancellationToken cancellationToken)
    {
        await Task.Yield();
        throw new NotImplementedException();
    }
}