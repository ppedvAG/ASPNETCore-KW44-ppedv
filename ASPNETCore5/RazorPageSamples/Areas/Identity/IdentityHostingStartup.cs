using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorPageSamples.Data;

[assembly: HostingStartup(typeof(RazorPageSamples.Areas.Identity.IdentityHostingStartup))]
namespace RazorPageSamples.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RazorPageSamplesContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RazorPageSamplesContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<RazorPageSamplesContext>();
            });
        }
    }
}