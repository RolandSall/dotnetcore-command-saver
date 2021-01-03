using System;
using AutoMapper;
using dotnetcore_command_saver.Repository;
using dotnetcore_command_saver.Services.CommandService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Newtonsoft.Json.Serialization;

namespace dotnetcore_command_saver {
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddNewtonsoftJson(s =>
            {
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
            
            services.AddScoped<ICommandRepository, CommandRepository>();
            services.AddScoped<ICommandService, CommandService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddDbContextPool<CommandContext>(
                    dbContextOptions => dbContextOptions
                        .UseMySql(
                            "server=localhost;user=root;password=root;database=commands",
                            new MySqlServerVersion(new Version(8, 0, 21)), 
                            mySqlOptions => mySqlOptions
                                .CharSetBehavior(CharSetBehavior.NeverAppend))
                        .EnableSensitiveDataLogging()
                        .EnableDetailedErrors());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "dotnetcore_command_saver", Version = "v1" });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "dotnetcore_command_saver v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
