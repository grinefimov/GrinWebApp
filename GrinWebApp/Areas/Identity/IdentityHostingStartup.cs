using System;
using GrinWebApp.Areas.Identity.Data;
using GrinWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GrinWebApp.Areas.Identity.IdentityHostingStartup))]
namespace GrinWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GrinWebApp")));

                services.AddDefaultIdentity<User>( options =>
                        options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<UserContext>();
            });
        }
    }
}