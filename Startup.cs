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
using Rki.CancerDataGenerator.Services;
using Microsoft.EntityFrameworkCore;
using Rki.CancerDataGenerator.Models.Dimensions;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Claims;

namespace Rki.CancerDataGenerator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IConfiguration _config { get; }


        /// <summary>
        /// API Versioning:
        /// https://codingfreaks.de/dotnet-core-api-versioning/
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(c => c.LowercaseUrls = true); // enforce lowercase
            services.AddControllersWithViews();     // light lighter option than MVC
            services.AddDbContext<AdtGekidDbContext>(options => options
                .UseLazyLoadingProxies()
                .UseInMemoryDatabase("CancerDataGenerator"));

            /* security */
            services.AddSingleton<IJwtAuthenticator, JwtAuthenticator>();   // add service as singleton
            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    //options.RequireHttpsMetadata = false;
                    //options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetValue<string>("JwtTokenPw"))),
                        ValidateAudience = false, 
                        // if ClockSkew is not nulled, 5min delay always apply!
                        ValidateLifetime = true, ClockSkew = TimeSpan.Zero,
                        ValidateIssuer = true, ValidIssuers = new string[] { "dexterDSD", "rki" }
                    };
                });

            /* Swagger */
            services.AddSwaggerGen(c =>
            {

                /* Versions */
                var v1 = new OpenApiInfo()
                {
                    Title = Globals.APPNAME,
                    Version = "v1",
                    License = new OpenApiLicense() { Name = "Testlicense", Url = new Uri("https://example.com/license") },
                    Contact = new OpenApiContact() { Name = "just me", Email = "me@exampl.com" },
                    Description = @"<h1>API</h1> <b>description</b> follows or even <br> this",
                };
                var v2 = v1;
                v2.Version = "v2";

                /* create versioned docs*/
                c.SwaggerDoc("v1", v1);
                c.SwaggerDoc("v2", v2);

                /* Authentification JUST SWagger */
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insert the received JWT token into field, no leading 'Bearer' keyword.<br> It is valid for 2hrs.",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                        },
                        new List<string>()
                    }
                });


                // Set the comments path for the Swagger JSON and UI.
                // Also note checking xml doc generation in build options
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

            });

            services.AddApiVersioning(o =>
               {
                   o.ReportApiVersions = true;
                   o.AssumeDefaultVersionWhenUnspecified = true;
                   o.DefaultApiVersion = new ApiVersion(1, 0);
               });
            services.AddVersionedApiExplorer(o =>
            {
                o.GroupNameFormat = "'v'VVV";
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


            app.UseAuthentication();
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
