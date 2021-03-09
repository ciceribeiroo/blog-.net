using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Configuration;
using blog.Data;
using blog.Data.FileManager;
using blog.Data.Repository;
using blog.Services.Email;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace blog
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<SmtpSettings>(_config.GetSection("SmtpSettings"));
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_config["DefaultConnection"]));
            
            services.AddMvc(options => options.EnableEndpointRouting = false);
            
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IFileManager, FileManager>();
            services.AddSingleton<IEmailServices, EmailServices>();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/Auth/Login";
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
            }
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseAuthentication();
            _ = app.UseMvcWithDefaultRoute();
            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });*/
        }
    }
}
