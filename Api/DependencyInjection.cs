using Api.Common.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, KeyDetectProblemDetailsFactory>();
        return services;
    }
}