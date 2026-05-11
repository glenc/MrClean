using Azure.Identity;
using MrClean.Application.Common.Interfaces;
using MrClean.Infrastructure.Data;
using MrClean.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MrClean.WebApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddScoped<IUser, CurrentUser>();

        services.AddHttpContextAccessor();

        services.AddExceptionHandler<CustomExceptionHandler>();

        return services;
    }
}
