using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ThaiContestApi.Config;
using ThaiContestApi.Middlewares;
using ThaiContestApi.Repository.ContestNs;
using ThaiContestApi.Repository.MongoConnectionNs;
using ThaiContestApi.Services.ContestNs;

namespace ThaiContestApi
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

            services.Configure<MongoConfig>(Configuration.GetSection(nameof(MongoConfig)));
            services.AddSingleton<IMongoConfig>(sp => sp.GetRequiredService<IOptions<MongoConfig>>().Value);
            services.AddSingleton<IMongoRepository, MongoRepository>();

            services.AddSingleton<IContestService, ContestService>();
            services.AddSingleton<IContestRepository, ContestRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ThaiContestApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ThaiContestApi v1");
                });
            }

            app.UseRouting();

            app.UseExceptionHandlingMiddleware();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
