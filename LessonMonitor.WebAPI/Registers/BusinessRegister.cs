using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.ThirdPartyServices.GithubService;
using LessonMonitor.BusinessLogic.Services;
using LessonMonitor.BusinessLogic.ThirdPartyService.Github;
using LessonMonitor.DAL.Repositories;
using LessonMonitor.WebAPI.Registers.Abstract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace LessonMonitor.WebAPI.Registers;

internal class BusinessRegister : IRegister
{
    public void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();

        //Swagger setup
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo 
            { 
                Title = "LessonMonitor.WebAPI", 
                Version = "v1"
            });
        });

        //Add services to DI mechanism
        AddScoped(services);
        AddTransient(services);
        AddSingleton(services);
    }


    private static void AddScoped(IServiceCollection services)
    {
        services.AddSingleton<IGroupRepository, GroupRepository>();
        services.AddSingleton<IMemberRepository, MemberRepository>();
        services.AddSingleton<IHomeworkRepository, HomeworkRepository>();
        services.AddSingleton<ILessonRepository, LessonRepository>();
    }

    private static void AddTransient(IServiceCollection services)
    {
        services.AddTransient<IGithubService, GithubService>();
    }

    private static void AddSingleton(IServiceCollection services)
    {
        services.AddScoped<IGroupService, GroupService>();
        services.AddScoped<IMemberService, MemberService>();
        services.AddScoped<IHomeworkService, HomeworkService>();
        services.AddScoped<ILessonService, LessonService>();
    }
}
