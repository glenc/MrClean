using System.Security.Claims;

using MrClean.Application.Common.Interfaces;

namespace MrClean.WebApi.Services;

public class CurrentUser(IHttpContextAccessor httpContextAccessor) : IUser
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public string? Id => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
}
