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
using Rki.CancerDataGenerator.DAL;
using Microsoft.EntityFrameworkCore;
using Rki.CancerDataGenerator.Models.Dimensions;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;

namespace Rki.CancerDataGenerator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        /// <summary>
        /// API Versioning:
        /// https://codingfreaks.de/dotnet-core-api-versioning/
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(c => c.LowercaseUrls = true); // enforce lowercase
            services.AddControllersWithViews();
            services.AddDbContext<AdtGekidDbContext>(options => options
                .UseLazyLoadingProxies()
                .UseInMemoryDatabase("CancerDataGenerator"));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = Globals.APPNAME,
                    Version = "v1",
                    Description = "API description follows",
                    License = new OpenApiLicense() { Name = "Testlicense", Url = new Uri("https://example.com/license") },
                    Contact = new OpenApiContact() { Name = "just me", Email = "me@exampl.com" }
                });
                c.SwaggerDoc("v2", new OpenApiInfo
                {
                    Title = Globals.APPNAME,
                    Version = "v2",
                    Description = "API description follows",
                    License = new OpenApiLicense() { Name = "Testlicense", Url = new Uri("https://example.com/license") },
                    Contact = new OpenApiContact() { Name = "just me", Email = "me@exampl.com" }
                });
                // Set the comments path for the Swagger JSON and UI.
                // Also note checking xml doc generation in build options
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                // HACK don not use
                //c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            services.AddApiVersioning(o =>
               {
                   o.ReportApiVersions = true;
                   o.AssumeDefaultVersionWhenUnspecified = true;
                   o.DefaultApiVersion = new ApiVersion(1, 0);
               });
            services.AddVersionedApiExplorer(o =>
            {
                o.GroupNameFormat = "'v'V";
                o.SubstituteApiVersionInUrl = true;
            });

    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AdtGekidDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
                    c.SwaggerEndpoint("/swagger/v2/swagger.json", "API v2");
                });
                context.Database.EnsureCreated();
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
