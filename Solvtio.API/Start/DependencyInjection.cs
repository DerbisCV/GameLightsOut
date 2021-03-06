using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Solvtio.Data;
using Solvtio.Data.Contracts;
using Solvtio.Data.Implementations;
using Solvtio.Services.Contracts;
using Solvtio.Services.Implementations;

namespace Solvtio.API.Start
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddTransient<IConfiguracionService, ConfiguracionService>()
                .AddTransient<IConfiguracionRepository, ConfiguracionRepository>()
                .AddTransient<ICaracteristicaBaseRepository, CaracteristicaBaseRepository>()
                //
                ;

            return services;
        }

        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SolvtioDbContext>(options =>
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"])
            );

            return services;
        }

        public static void UpgradeDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SolvtioDbContext>();
                if (context != null && context.Database != null)
                {
                    context.Database.Migrate();
                    context.SeedDataInitial();
                }
            }
        }
    }
}
