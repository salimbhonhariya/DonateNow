using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonateNow.Data;
using DonateNow.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DonateNow
{
    public class Startup
    {
        
        public Startup(IHostingEnvironment env)
        {
             var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            var connectionStringConfig = builder.Build();
            var config = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEntityFrameworkConfig(options => options.UseSqlServer(connectionStringConfig.GetConnectionString("DefaultConnection")));
            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();
            Configuration = config.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddOptions();

            // Add framework services.
            services.AddDbContext<DonateNowDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Inject the configuration object for settings
            services.AddSingleton<IConfiguration>(Configuration);

            // Add application services.
            services.AddScoped<Idonor, DonorCreator>();

           // services.AddSwaggerPageConfiguration();
            services.AddLogging();
          //  Seed(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
            DonateNowDataContext context, IConfiguration configuration)
        {

            loggerFactory
              .AddConsole(Configuration.GetSection("Logging"))
              .AddDebug()
              .AddAzureWebAppDiagnostics();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
           // app.UseResponseCompression();
            app.UseStaticFiles();

            // app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Donor", action = "Index" });
            });

          
            DbInitializer.Initialize(context);

        }
       


    }
}
