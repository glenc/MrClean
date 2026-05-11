using MrClean.Common.Interfaces;
using MrClean.Common.Security;

namespace MrClean.FeatureName.Commands.MrCleanUseCase;

public record MrCleanUseCaseCommand : IRequest<ReturnType>
{
    
}

public class MrCleanUseCaseCommandValidator : AbstractValidator<MrCleanUseCaseCommand>
{
    public MrCleanUseCaseCommandValidator()
    {

    }
}

public class MrCleanUseCaseCommandHandler(IApplicationDbContext context, IUser user) : IRequestHandler<MrCleanUseCaseCommand, ReturnType>
{
    private readonly IApplicationDbContext _context = context;
    private readonly IUser _user = user;

    public async Task<ReturnType> Handle(MrCleanUseCaseCommand request, CancellationToken cancellationToken)
    {
        await Task.Yield();
        throw new NotImplementedException();
    }
}