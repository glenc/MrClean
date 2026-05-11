using MrClean.Common.Interfaces;
using MrClean.Common.Security;

namespace MrClean.FeatureName.Queries.MrCleanUseCase;

public record MrCleanUseCaseQuery : IRequest<ReturnType>
{
    public int Id { get; init; }
}

public class MrCleanUseCaseQueryValidator : AbstractValidator<MrCleanUseCaseQuery>
{
    public MrCleanUseCaseQueryValidator()
    {
    }
}

public class MrCleanUseCaseQueryHandler(IApplicationDbContext context, IMapper mapper) : IRequestHandler<MrCleanUseCaseQuery, ReturnType>
{
    private readonly IApplicationDbContext _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<ReturnType> Handle(MrCleanUseCaseQuery request, CancellationToken cancellationToken)
    {
        await Task.Yield();
        throw new NotImplementedException();
    }
}
