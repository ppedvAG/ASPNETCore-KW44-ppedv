using DependencyInversionInASPNETCORE;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageSamples.Data;
using Westwind.AspNetCore.LiveReload;
using Microsoft.AspNetCore.Http;
using RazorPageSamples.Middleware;
using Microsoft.AspNetCore.Mvc;

namespace RazorPageSamples
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
            services.AddLiveReload();

            //services.AddLiveReload(config =>
            //{
            //    // optional - use config instead
            //    //config.LiveReloadEnabled = true;
            //    //config.FolderToMonitor = Path.GetFullname(Path.Combine(Env.ContentRootPath,"..")) ;
            //});

            services.AddRazorPages()
                .AddRazorRuntimeCompilation();


            

            services.AddSingleton<ICar, MockCar>();

            services.AddDbContext<MovieDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MovieDbContext")));

            services.AddResponseCaching();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseLiveReload();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();


            app.UseResponseCaching();

            app.UseStaticFiles(); //wwwroot 

            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();

            AppDomain.CurrentDomain.SetData("BildVerzeichnis", env.WebRootPath);


            #region Customize Middleware

            //Middleware wird aktiv, wenn im Request "imagegen" angegeben wird
            app.MapWhen(context => context.Request.Path.ToString().Contains("imagegen"), subapp =>
            {
                subapp.UseThumbnailGen();
            });
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
