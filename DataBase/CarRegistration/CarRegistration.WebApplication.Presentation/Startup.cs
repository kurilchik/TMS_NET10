using CarRegistration.BusinessLogicLayer.Services;
using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRegistration.WebApplication.Presentation
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
            services.AddControllersWithViews();

            services.AddDbContext<CarDbContext>(
                options => options.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=Car;Trusted_Connection=True;"));

            services.AddTransient<IDeveloperRepository, DeveloperRepository>();
            services.AddTransient<IDeveloperService, DeveloperService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Developer}/{action=Index}/{id?}");
            });
        }
    }
}
