using AutoMapper;
using CivilMaster.App.Models.Collaborator;
using CivilMaster.App.Models.Work;
using CivilMaster.Application.Collaborators;
using CivilMaster.Application.Collaborators.Interfaces;
using CivilMaster.Application.Decorators;
using CivilMaster.Application.Works;
using CivilMaster.Application.Works.Interfaces;
using CivilMaster.DataAccess;
using CivilMaster.DataAccess.Repositories;
using CivilMater.Domain.AllocateCollaborators;
using CivilMater.Domain.CreateCollaborator;
using CivilMater.Domain.CriarObras;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CivilMaster.App
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddAutoMapper(options =>
            {
                options.CreateMap<CreateWorkRequest, Work>();
                options.CreateMap<Work, CreateWorkRequest>();
                options.CreateMap<Work, WorkModel>();
                options.CreateMap<WorkModel, Work>();

                options.CreateMap<CreateCollaboratorRequest, Collaborator>();
                options.CreateMap<Collaborator, CreateCollaboratorRequest>();

            });


            var connection = @"Host=localhost;Port=5432;Pooling=true;Database=CIVIL_MASTER_DB;User Id=postgres;Password=#abc123;";

            //services.AddDbContext<CivilMasterContext>(options => options.UseNpgsql(connection));
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<CivilMasterContext>(options => options.UseNpgsql(connection));

            //repositorios
            services.AddScoped<IWorkRepository, WorkRepository>();
            services.AddScoped<ICollaboratorRepository, CollaboratorRepository>();
            services.AddScoped<IAllocationRepository, AllocationRepository>();
            services.AddScoped<IUnityOfWork, UnityOfWork>();

            //dominios
            services.AddScoped<ICreateWork, CreateWork>();
            services.AddScoped<ICreateCollaborator, CreateCollaborator>();
            services.AddScoped<IAllocateCollaborator, AllocateCollaborator>();
            services.AddScoped<IWorkAppService, WorkAppService>();
            services.AddScoped<ICollaboratorAppService, CollaboratorAppService>();
            
            // decorators
            services.Decorate<IWorkAppService, WorkAppServiceTransactionDecorator>();
            services.Decorate<ICollaboratorAppService, CollaboratorAppServiceTransactionDecorator>();


            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
