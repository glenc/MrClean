using MrClean.Common.Interfaces;
using MrClean.Common.Security;

namespace MrClean.FeatureName.Queries.MrCleanUseCase;

public record MrCleanUseCaseQuery : IRequest<ReturnType>
{
}

public class MrCleanUseCaseQueryValidator : AbstractValidator<MrCleanUseCaseQuery>
{
    public MrCleanUseCaseQueryValidator()
    {
    }
}

public class MrCleanUseCaseQueryHandler : IRequestHandler<MrCleanUseCaseQuery, ReturnType>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public MrCleanUseCaseQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ReturnType> Handle(MrCleanUseCaseQuery request, CancellationToken cancellationToken)
    {
        await Task.Yield();
        throw new NotImplementedException();
    }
}
