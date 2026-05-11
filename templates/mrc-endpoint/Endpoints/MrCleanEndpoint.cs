using Microsoft.AspNetCore.Http.HttpResults;

namespace MrClean.Endpoints;

public class MrCleanEndpoint : IEndpointGroup
{
    public RouteGroupBuilder MapEndpoints(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(this)
            .RequireAuthorization();

        group
            .MapGet(List)
            .MapGet(Get, "{IdParam}")
            .MapPost(Create)
            .MapPut(Update, "{IdParam}");
        
        return group;
    }

    public async Task<Ok<object>> List(ISender sender)
    {
        await Task.Yield();
        throw new NotImplementedException();

        // var result = null;
        // return TypedResults.Ok(result);
    }

    public async Task<Ok<object>> Get(ISender sender, int IdParam)
    {
        await Task.Yield();
        throw new NotImplementedException();

        // var result = null;
        // return TypedResults.Ok(result);
    }

    public async Task<Created<int>> Create(ISender sender, object command)
    {
        await Task.Yield();
        throw new NotImplementedException();

        // var result = await sender.Send(command);
        // return TypedResults.Created($"/{nameof(MrCleanEndpoint)}/{result}", result);
    }

    public async Task<Results<NoContent, BadRequest>> Update(ISender sender, int IdParam, object command)
    {
        await Task.Yield();
        throw new NotImplementedException();
        
        // if (IdParam != command.Id) return TypedResults.BadRequest();

        // await sender.Send(command);

        // return TypedResults.NoContent();
    }
}