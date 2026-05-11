using MrClean.Infrastructure.Identity;

namespace MrClean.WebApi.Endpoints;

public class Users : IEndpointGroup
{
    public RouteGroupBuilder MapEndpoints(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(this);
        group.MapIdentityApi<ApplicationUser>();

        return group;
    }
}
