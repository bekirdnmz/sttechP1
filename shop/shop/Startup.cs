﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using shop.Data;
using shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop
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
            //geçici: her request'de ve her kullanıldığına yeni bir instance alınacak.
            services.AddSession();
            //IoC
            services.AddTransient<IProductService, EFProductService>();
            services.AddScoped<ICategoryService, EFCategoryService>();
            services.AddScoped<IUserService, FakeUserService>();
            //scoped: her request'de yeni instance, fakat tüm projede (ne kadar kullanılırsa) aynı instance.
            //services.AddScoped();
            //tek: yalnızca bir instance yetiyorsa:
            //services.AddSingleton();
            var connectionString = Configuration.GetConnectionString("shopDb");
            services.AddDbContext<ShopDbContext>(opt => opt.UseSqlServer(connectionString));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(opt =>
                    {
                        opt.LoginPath = "/Users/Login";
                        opt.AccessDeniedPath = "/Users/AccessDenied";
                        
                    });

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapAreaControllerRoute(
                //    name: "MyAreaServices",
                //    areaName: "StoreArea",
                //    pattern: "StoreArea/{controller=Store}/{action=Index}/{id?}");

               endpoints.MapControllerRoute(
               name: "areaRoute",
               pattern: "{area:exists}/{controller=Store}/{action=Index}");

                endpoints.MapControllerRoute(
                   name: "paging",
                   pattern: "Sayfa/{page}",
                   defaults: new { controller = "Home", action = "Index", page = 1 });


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

               




            });
        }
    }
}
