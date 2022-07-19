using LessonMonitor.WebAPI.Registers.Abstract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LessonMonitor.WebAPI.Registers.Helper;

internal static class ServiceRegisterHelper
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        var typesImplementingServicesRegistration = typeof(Startup).Assembly.GetTypes()
            .Where(x => !x.IsAbstract && !x.IsInterface && typeof(IRegister).IsAssignableFrom(x))
            .Select(x => Activator.CreateInstance(x))
            .Cast<IRegister>()
            .ToList();

        typesImplementingServicesRegistration.ForEach(x => x.RegisterServices(services, configuration));
    }
}
