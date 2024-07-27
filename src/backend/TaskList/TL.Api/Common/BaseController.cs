using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TL.Api.Common
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected ISender _sender;
        public BaseController()
        {
            _sender = HttpContext.RequestServices.GetRequiredService<ISender>();
        }
    }
}
