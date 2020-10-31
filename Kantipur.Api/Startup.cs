using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System.Data.SqlClient;
using AutoMapper;
using Kantipur.Persistence.DataContexts;
using Kantipur.Persistence.Repositories.IRepository;
using Models.Mappers;
using Kantipur.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using Scenarios.CarScenarios;
using Scenarios.ContainerScenarios;

namespace Kantipur.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        private readonly Assembly[] _assemblies =
        {
            typeof(GetCarsRequest).Assembly,
            typeof(CreateCarHandler).Assembly,
            typeof(GetContainerRequest).Assembly,
            typeof(CreateContainerHandler).Assembly
        };

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddSwaggerDocument(configure => configure.Title = "Kantipur API");

            var builder = new SqlConnectionStringBuilder(Configuration["KantipurApp:ConnectionStrings:AzureParulDb"])
            {
                Password = Configuration["KantipurApp:ConnectionStrings:AzureParulDbPassword"]
            };
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.ConnectionString));

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ContainerMappings());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IContainerRepository, ContainerRepository>();
            services.AddMediatR(_assemblies);
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
