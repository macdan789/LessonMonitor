using LessonMonitor.AbstractCore.AbstractRepositories;
using LessonMonitor.AbstractCore.AbstractServices;
using LessonMonitor.AbstractCore.ThirdPartyServices.GithubService;
using LessonMonitor.BusinessLogic.Services;
using LessonMonitor.BusinessLogic.ThirdPartyService.Github;
using LessonMonitor.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace LessonMonitor.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LessonMonitor.WebAPI", Version = "v1" });
            });

            //Add services to DI
            AddScoped(services);
            AddTransient(services);
            AddSingleton(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LessonMonitor.WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseMiddleware<HeaderHandlerMiddleware>();
            //app.UseMiddleware<RequestLogMiddleware>();
            // OR I CAN USE CUSTOM STATIC EXTENTION METHODS
            //app.UseHeaderHandlerMiddleware();
            //app.UseRequestLogMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

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
}
