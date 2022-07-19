using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LessonMonitor.WebAPI.Registers.Abstract;

internal interface IRegister
{
    void RegisterServices(IServiceCollection services, IConfiguration configuration);
}
