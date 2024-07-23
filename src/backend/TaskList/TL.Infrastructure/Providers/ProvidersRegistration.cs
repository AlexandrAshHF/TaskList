using Microsoft.Extensions.DependencyInjection;
using TL.Infrastructure.Abstractions.Providers;

namespace TL.Infrastructure.Providers
{
    public static class ProvidersRegistration
    {
        public static IServiceCollection AddProviders(this IServiceCollection services)
        {
            services.AddScoped<IUserProvider, UserProvider>();

            return services;
        }
    }
}
