using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TaskTimeTracker.Entities;
using Swashbuckle.AspNetCore.Swagger;
using TaskTimeTracker.IServices;
using TaskTimeTracker.Services;
using Microsoft.AspNetCore.Authentication;
using TaskTimeTracker.Helpers;
using AutoMapper;
using TaskTimeTracker.Services.Queries;
using TaskTimeTracker.Services.Commands;

namespace TaskTimeTracker
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
            services.AddCors();
            services.AddAutoMapper();

            // old services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITodoService, TodoService>();
            services.AddScoped<IProjectService, ProjectService>();

            services.AddScoped<ITodoQueryService, TodoQueryService>();
            services.AddScoped<IUserQueryService, UserQueryService>();
            services.AddScoped<IProjectQueryService, ProjectQueryService>();
            services.AddScoped<ITodoCommandService, TodoCommandService>();
            services.AddScoped<IUserCommandService, UserCommandService>();
            services.AddScoped<IProjectCommandService, ProjectCommandService>();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<UserContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:tasktime"]));
            services.AddSwaggerGen(context =>
            {
                context.SwaggerDoc("v1", new Info() { Title = "User Api", Version = "v1" });
                context.OperationFilter<BasicAuthFilter>();
            });
            services.AddAuthentication("BasicAuthentication").
                AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "User API V1");
                });
            }

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
