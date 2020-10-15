using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using MHFoodBank.Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Hangfire;
using Hangfire.MySql.Core;
using AutoMapper;
using MHFoodBank.Web.Repositories;
using MHFoodBank.Common;
using MHFoodBank.Web.Services;

namespace MHFoodBank.Web
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
            services.AddDbContext<FoodBankContext>(options =>
            {
                options.UseMySql(
                    Configuration.GetConnectionString("MainDevConnection"));
            });

            services.AddIdentity<AppUser, IdentityRole<int>>(options =>
                    options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<FoodBankContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            services.AddHangfire(options => options
                .UseSerializerSettings(new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })
                .UseStorage(
                    new MySqlStorage(
                        Configuration.GetConnectionString("HangfireDevConnection"),
                        new MySqlStorageOptions
                        {
                            TransactionIsolationLevel = System.Data.IsolationLevel.ReadCommitted,
                            QueuePollInterval = TimeSpan.FromSeconds(15),
                            JobExpirationCheckInterval = TimeSpan.FromHours(1),
                            CountersAggregateInterval = TimeSpan.FromMinutes(5),
                            PrepareSchemaIfNecessary = true,
                            DashboardJobListLimit = 50000,
                            TransactionTimeout = TimeSpan.FromMinutes(1)
                        }
                    )));
            JobStorage.Current = new MySqlStorage(
                        Configuration.GetConnectionString("HangfireConnection"),
                        new MySqlStorageOptions
                        {
                            TransactionIsolationLevel = System.Data.IsolationLevel.ReadCommitted,
                            QueuePollInterval = TimeSpan.FromSeconds(15),
                            JobExpirationCheckInterval = TimeSpan.FromHours(1),
                            CountersAggregateInterval = TimeSpan.FromMinutes(5),
                            PrepareSchemaIfNecessary = true,
                            DashboardJobListLimit = 50000,
                            TransactionTimeout = TimeSpan.FromMinutes(1)
                        }
                    );

            services.AddOptions();
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));

            services.AddHangfireServer();
            services.AddScoped<IReminderManager, ReminderManager>();
            services.AddScoped<IEmailSender, MailKitEmailSender>();
            services.AddScoped<IEmailConfirmationService, EmailConfirmationService>();
            services.AddScoped<IPasswordRecoveryService, PasswordRecoveryService>();
            services.AddScoped<IEmailAvailableShiftService, EmailAvailableShiftService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IClockedTimeRepo, ClockedTimeRepo>();
            services.AddScoped<IDbSeeder, DbSeeder>();

            services
                .AddRazorPages()
                .AddNewtonsoftJson(options =>
                    options
                    .UseMemberCasing()
                    .SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)

                .AddRazorPagesOptions(options =>
                    options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", ""));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbSeeder seeder, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE5MzQ4QDMxMzgyZTMyMmUzMEI2L0VJSnNCS1ZaaUh1WjUyditEWUsvMzZHaDJmc1IzQTBKZkxaTGM2Vzg9");

            seeder.Seed(env.IsDevelopment());

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            GlobalConfiguration.Configuration.UseActivator(new CustomJobActivator(serviceProvider));
            app.UseHangfireDashboard("/jobs");
            app.UseHangfireServer();

            RecurringJob.AddOrUpdate<IEmailAvailableShiftService>(x => x.SendNotifications(), Cron.Weekly(DayOfWeek.Saturday));
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
