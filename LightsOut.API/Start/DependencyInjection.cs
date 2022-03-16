using LightsOut.Services.Contracts;
using LightsOut.Services.Data;
using LightsOut.Services.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LightsOut.API.Start
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddTransient<ILightsOutService, LightsOutService>()
                .AddTransient<ILightsOutSettingRepository, LightsOutSettingRepository>();

            return services;
        }

        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LightsOutDbContext>(options =>
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"])
            );

            return services;
        }

        public static void UpgradeDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LightsOutDbContext>();
                if (context != null && context.Database != null)
                {
                    context.Database.Migrate();
                    context.SeedDataInitial();
                }
            }
        }
    }
}
