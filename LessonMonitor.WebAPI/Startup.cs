using LessonMonitor.AbstractCore.AbstractRepository;
using LessonMonitor.AbstractCore.AbstractService;
using LessonMonitor.AbstractCore.GithubService;
using LessonMonitor.BusinessLogic.Github;
using LessonMonitor.BusinessLogic.Service;
using LessonMonitor.DAL.Repository;
using LessonMonitor.WebAPI.CustomMiddleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Octokit;

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

            app.UseMiddleware<HeaderHandlerMiddleware>();
            app.UseMiddleware<RequestLogMiddleware>();
            // OR I CAN USE CUSTOM STATIC EXTENTION METHODS
            //app.UseHeaderHandlerMiddleware();
            //app.UseRequestLogMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

        private void AddScoped(IServiceCollection services)
        {
            services.AddSingleton<IGroupRepository, GroupRepository>();
            services.AddSingleton<IMemberRepository, MemberRepository>();
        }

        private void AddTransient(IServiceCollection services)
        {
            services.AddTransient<IGithubService, GithubService>();
        }

        private void AddSingleton(IServiceCollection services)
        {
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IMemberService, MemberService>();
        }
    }
}
