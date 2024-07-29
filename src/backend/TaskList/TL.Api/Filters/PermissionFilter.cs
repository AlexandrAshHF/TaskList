using Microsoft.AspNetCore.Mvc.Filters;
using TL.Infrastructure.Abstractions.Providers;

namespace TL.Api.Filters
{
    public class PermissionFilter : Attribute, IAsyncResourceFilter
    {
        private readonly IPermissionProvider _permissionProvider;
        private readonly IUserProvider _userProvider;

        public PermissionFilter(IPermissionProvider permissionProvider, IUserProvider userProvider)
        {
            _permissionProvider = permissionProvider;
            _userProvider = userProvider;
        }

        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            await next();
        }
    }
}
