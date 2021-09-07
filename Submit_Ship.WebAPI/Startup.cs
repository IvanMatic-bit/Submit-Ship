using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Submit_Ship.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Submit_Ship.WebAPI.Services;
using Submit_Ship.Model;
using Submit_Ship.Model.Requests;
using Microsoft.AspNetCore.Authentication;
using Submit_Ship.WebAPI.Security;
using Newtonsoft.Json;

namespace Submit_Ship.WebAPI
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
            services.AddMvc().AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
           services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Submit_Ship.WebAPI", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            
            services.AddDbContext<SubmitShipContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICRUDService<Model.Drzava, object, DrzavaInsertRequest, DrzavaInsertRequest>, BaseCRUDService<Model.Drzava, object, Database.Drzava, DrzavaInsertRequest, DrzavaInsertRequest>>();
            services.AddScoped<ICRUDService<Model.Adresa, object, AdresaUpsertRequest, AdresaUpsertRequest>, BaseCRUDService<Model.Adresa, object, Database.Adresa, AdresaUpsertRequest, AdresaUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Grad, object, GradUpsertRequest, GradUpsertRequest>, BaseCRUDService<Model.Grad, object, Database.Grad, GradUpsertRequest, GradUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Isporuka, IsporukaSearchRequest, IsporukaUpsertRequest, IsporukaUpsertRequest>, IsporukeService>();
            services.AddScoped<ICRUDService<Model.Kamion, object, KamionUpsertRequest, KamionUpsertRequest>, BaseCRUDService<Model.Kamion, object, Database.Kamion, KamionUpsertRequest, KamionUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Usluga, object, UslugaUpsertRequest, UslugaUpsertRequest>, BaseCRUDService<Model.Usluga, object, Database.Usluga, UslugaUpsertRequest, UslugaUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Zahtjev, ZahtjevSearchRequest, ZahtjevUpsertRequest, ZahtjevUpsertRequest>, ZahtjeviService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Model.Kvar, KvarSearchRequest, KvarUpsertRequest, KvarUpsertRequest>,  KvaroviService>();

            services.AddScoped<IService<Model.StatusIsporuke, object>, BaseService<Model.StatusIsporuke, object, Database.StatusIsporuke>>();
            services.AddScoped<IService<Model.StatusZahtjeva, object>, BaseService<Model.StatusZahtjeva, object, Database.StatusZahtjeva>>();
            services.AddScoped<IService<Model.Uloga, object>, BaseService<Model.Uloga, object, Database.Uloga>>();

            services.AddScoped<IRecommenderService, RecommenderService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
          
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Submit_Ship.WebAPI v1"));
            
            
           // app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
