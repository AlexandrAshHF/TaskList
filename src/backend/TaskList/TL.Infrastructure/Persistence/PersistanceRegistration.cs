using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TL.Application.Common.Persistance;
using TL.Application.Common.Persistance.Repositories;
using TL.Infrastructure.Persistance.Contexts;
using TL.Infrastructure.Persistence.Repositories;

namespace TL.Infrastructure.Persistence
{
    public static class PersistanceRegistration
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TLDbContext>(options => options
                .UseLazyLoadingProxies()
                .UseNpgsql(configuration.GetConnectionString("TLDbConnection"))
            );

            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IEmplInAppRepository, EmplInAppRepositoty>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
