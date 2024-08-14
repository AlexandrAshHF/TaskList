using Microsoft.Extensions.DependencyInjection;
using TL.Infrastructure.Extensions.Pagination;

namespace TL.Infrastructure.Extensions
{
    public static class ExtensionsRegistration
    {
        public static IServiceCollection AddExtensions(this IServiceCollection services)
        {
            services.AddScoped<IPageGenerator, PageGenerator>();

            return services;
        }
    }
}
