using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyLibraryStore.Data;
using MyLibraryStore.Repository;

namespace MyLibraryStore
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(_configuration.GetConnectionString("Library")));
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseRouting();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is use middleware\n");
            //    await next();
            //});

            //app.Run(async x =>
            //{
            //    await x.Response.WriteAsync("Message from run");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                //endpoints.MapGet("/", async context =>
                //{
                //    //await context.Response.WriteAsync("Hello World!");
                //    await context.Response.WriteAsync(_configuration["MyKey"]);
                //});
            });
        }
    }
}
