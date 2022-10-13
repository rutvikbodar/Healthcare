using Healthcare.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare
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
            services.AddDbContext<HealthcareDbContext>(option => option.UseInMemoryDatabase(Configuration.GetConnectionString("MyDb")));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "login",
                    template: "{controller=Login}/{action=Login}");
                routes.MapRoute(
                    name: "register",
                    template: "{controller=Register}/{action=Index}");
                routes.MapRoute(
                    name: "adminhome",
                    template: "{controller=AdminHome}/{action=Index}");
                routes.MapRoute(
                    name: "addmedicine",
                    template: "{controller=AddMedicine}/{action=Index}");
                routes.MapRoute(
                    name: "adminViewDonations",
                    template: "{controller=AdminViewDonations}/{action=Index}");
                routes.MapRoute(
                    name: "adminViewRequests",
                    template: "{controller=AdminViewRequests}/{action=Index}");
            });
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<HealthcareDbContext>();
            SeedData(context);
        }

        public static void SeedData(HealthcareDbContext context)
        {
            User user = new User
            {
                username = "Admin",
                password = "Admin@123",
                address = "NYC, USA",
                age = 21,
                gender = "Male"
            };
            context.users.Add(user);
            context.SaveChanges();
        }
    }
}
