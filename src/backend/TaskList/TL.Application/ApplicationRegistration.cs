using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TL.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(opth => opth.RegisterServicesFromAssembly(assembly));

            return services;
        }
    }
}
