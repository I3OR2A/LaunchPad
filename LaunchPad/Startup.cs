﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using LaunchPad.Data;
using Microsoft.EntityFrameworkCore;
using Hangfire;
using LaunchPad.Services;

namespace LaunchPad
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
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Add framework services.
            services.AddMvc();
            services.AddHangfire(config => config.UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection")));

            // Add DI

            services.AddTransient<IScriptRepository, PowerShellRepository>();
            services.AddTransient<IScriptIO, ScriptIO>();
            services.AddTransient<IJobServices, JobServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
			
			 // HangFire
            app.UseHangfireServer();
            app.UseHangfireDashboard("/PowerShell/Jobs");
			
        }
    }
}
