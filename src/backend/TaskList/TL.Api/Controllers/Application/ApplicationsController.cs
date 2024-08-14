using Microsoft.AspNetCore.Mvc;
using TL.Api.Common;
using TL.Application.Application.Commands.Create;
using TL.Application.Application.Queries.GetApplications;
using TL.ApplicationDto.Common;
using TL.Infrastructure.Persistance.Contexts;

namespace TL.Api.Controllers.Application
{
    public class ApplicationsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetApplicationsQuery request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateApplicationCommand request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}