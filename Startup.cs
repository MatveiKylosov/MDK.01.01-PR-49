using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MDK._01._01_PR_49
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Руководство для использования запросов",
                    Description = "Полное руководство для использования запросов находящихся в проекте"
                });

                c.SwaggerDoc("v2", new OpenApiInfo
                {
                    Version = "v2",
                    Title = "Руководство для использования запросов",
                    Description = "Полное руководство для использования запросов находящихся в проекте"
                });

                c.SwaggerDoc("v3", new OpenApiInfo
                {
                    Version = "v3",
                    Title = "Руководство для использования запросов",
                    Description = "Полное руководство для использования запросов находящихся в проекте"
                });

                c.SwaggerDoc("v4", new OpenApiInfo
                {
                    Version = "v4",
                    Title = "Руководство для использования запросов",
                    Description = "Полное руководство для использования запросов находящихся в проекте"
                });

                var filtePath = Path.Combine(System.AppContext.BaseDirectory, "MDK.01.01-PR-49.xml");
                c.IncludeXmlComments(filtePath);
            }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseMvcWithDefaultRoute();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Запросы на авторизацию и регистрацию.");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "Запросы для версий.");
                c.SwaggerEndpoint("/swagger/v3/swagger.json", "Запросы для блюд.");
                c.SwaggerEndpoint("/swagger/v4/swagger.json", "Запросы для заказов.");
            });

        }
    }
}
