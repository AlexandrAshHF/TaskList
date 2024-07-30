using Microsoft.AspNetCore.Mvc;
using TL.Api.Common;
using TL.Infrastructure.Persistance.Contexts;

namespace TL.Api.Controllers.Application
{
    public class ApplicationsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get(TLDbContext context)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
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