using AutoMapper;
using CustomerSite.Mapping;
using CustomerSite.Services;
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

namespace CustomerSite
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddControllersWithViews();
            services.AddHttpClient<IProductService, ProductService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<ISizeService, SizeService>();
            services.AddScoped<ICategoriesService, CategoriesService>();
            services.AddScoped<IRateService, RateService>();
            services.AddAutoMapper(c => c.AddProfile<ProductAutoMapping>(), typeof(Startup));
            services.AddAutoMapper(c => c.AddProfile<ImageAutoMapping>(), typeof(Startup));
            services.AddAutoMapper(c => c.AddProfile<CategoryAutoMapping>(), typeof(Startup));
            services.AddAutoMapper(c => c.AddProfile<SizeAutoMapping>(), typeof(Startup));
            services.AddAutoMapper(c => c.AddProfile<RateAutoMapping>(), typeof(Startup));
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
