using blog.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            try
            {
                var scope = host.Services.CreateScope();
                var ctx = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                var userMgn = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleMgn = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                ctx.Database.EnsureCreated();

                var adminRole = new IdentityRole("admin");
                if (!ctx.Roles.Any())
                {
                    roleMgn.CreateAsync(adminRole).GetAwaiter().GetResult();
                }
                if (!ctx.Users.Any(u => u.UserName == "admin"))
                {
                    var adminUser = new IdentityUser
                    {
                        UserName = "admin",
                        Email = "admin@teste.com"
                    };
                    var result = userMgn.CreateAsync(adminUser, "password").GetAwaiter().GetResult();
                    userMgn.AddToRoleAsync(adminUser, adminRole.Name).GetAwaiter().GetResult();
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
