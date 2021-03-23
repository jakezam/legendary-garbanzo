using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using Microsoft.OpenApi.Models;
using legendary_garbanzo.Data;
using legendary_garbanzo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        /// <summary>
        ///  This method gets called by the runtime. Use this method to add services to the container. 
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            // Allow Cors
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
                    });
            });
            
            // Configure DbContext
            services.AddDbContext<DataContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("database-connection")));

            // Add Controllers
            services.AddControllers();

            // Add DTO Automapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
            // Add Data Scope
            services.AddScoped<IData, SqlData>();
            
            // Add Swagger
            services.AddSwaggerGen(c =>
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyVersion = assembly.GetName().Version;
                
                c.SwaggerDoc("v" + assemblyVersion, new OpenApiInfo
                {
                    Title = "Inployed API",
                    Version = "v" + Configuration["Version"],
                    Description = "Inployed API",
                    Contact = new OpenApiContact
                    {
                        Name = string.Empty,
                        Email = string.Empty,
                        Url = new Uri("https://localhost:5001/")
                    }
                });
                
                // TODO: Is there a better way to handle Swagger REST Call documentation?
                var filePath = Path.Combine(AppContext.BaseDirectory, "legendary-garbanzo.xml");
                c.IncludeXmlComments(filePath);
            });
        }

        /// <summary>
        ///  This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyVersion = assembly.GetName().Version;
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v{assemblyVersion}/swagger.json", "Inployed API");
                c.RoutePrefix = string.Empty;
            });
            
            app.UseCors();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}