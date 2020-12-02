using System;
using DoAPI.DataAccess;
using DoAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DoAPI
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
            services.AddCors(policy =>
            {
                policy.AddPolicy("CorsPolicy", opt => opt
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });
            
            services.AddControllers();
            services.AddDbContext<MyDbContext>(options => options.UseSqlite("Data Source=data.db"));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IFamilyService, FamilyService>();
            services.AddScoped<IAdultService, AdultService>();
            services.AddScoped<IChildService, ChildService>();
            services.AddScoped<IFilterService, FilterService>();
            services.AddScoped<IPetService, PetService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.Use(async (context, next) =>
            {
                DateTime start = DateTime.Now;

                await next.Invoke();

                DateTime end = DateTime.Now;

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write($" {context.Request.Method} ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($" {context.Request.Path.Value}");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($" {context.Response.StatusCode}");
                Console.ResetColor();

                Console.WriteLine($" {(end - start).TotalMilliseconds:N3}ms");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}