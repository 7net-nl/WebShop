using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TShop.Infrascture.DataBase.EF;
using TShop.Service.Application;
using TShop.UI.Web.Data;

namespace TShop.UI.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(c => c.UseSqlite(Configuration.GetConnectionString("default")));
            services.AddSession();
            services.AddMemoryCache();

            services.AddAutoMapper(option=> 
            {
                option.AddProfile(new MappingProfile());
            });
            services.CustomService();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddSessionStateTempDataProvider();
            services.Configure<RazorViewEngineOptions>(c =>
            {
                c.AreaPageViewLocationFormats.Add("/Views/Shared/Layout/{0}.cshtml");
                c.AreaPageViewLocationFormats.Add("/Views/Shared/Main/{0}.cshtml");
                c.ViewLocationFormats.Add("/Views/Shared/Layout/{0}.cshtml");
                c.ViewLocationFormats.Add("/Views/Shared/Main/{0}.cshtml");
                
            });

            services.AddDbContext<MyIdentityDbContext>(c => c.UseSqlite(Configuration.GetConnectionString("Identity")));
            services.AddDefaultIdentity<Users>().AddEntityFrameworkStores<MyIdentityDbContext>().AddDefaultUI(UIFramework.Bootstrap4).AddDefaultTokenProviders();

            services.AddAuthorization(c =>
            {
                c.AddPolicy("CheckCity", d =>
                {
                   
                    d.RequireClaim("City", "Tehran");
                    d.Requirements.Add(new MyAutorizationRequiment());
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStatusCodePages();
            app.UseStatusCodePagesWithRedirects("{0}");
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
