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

            #region HOW MiddleWare Pipeline Containers Work
            //First Pipeline Block
            app.Use((httpContext, next) =>
            {
                //logic before calling next pipeline block

                var nextPipelineContainer = next(); //goes to Second Pipeline Block

                //logic after next pipeline block completing

                return nextPipelineContainer; // return Response after Pipeline Request Processing
            });

            //Second Pipeline Block
            app.Use((httpContext, next) =>
            {
                //logic before calling next pipeline block

                var nextPipelineContainer = next(); //goes to Third Pipeline Block

                //logic after next pipeline block completing

                return nextPipelineContainer; //return result to First Pipeline Block
            });

            //Third Pipeline Block
            app.Use((httpContext, next) =>
            {
                //logic before calling next pipeline block

                var nextPipelineContainer = next();

                //logic after next pipeline block completing

                return nextPipelineContainer; //return result to Second Pipeline Block 
            });
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
