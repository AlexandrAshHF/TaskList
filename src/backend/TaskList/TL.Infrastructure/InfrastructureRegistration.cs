using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TL.Infrastructure.Extensions;
using TL.Infrastructure.Persistence;
using TL.Infrastructure.Providers;

namespace TL.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistance(configuration);
            services.AddProviders();
            services.AddExtensions();

            return services;
        }
    }
}
