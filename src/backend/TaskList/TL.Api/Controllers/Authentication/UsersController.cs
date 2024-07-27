using Microsoft.AspNetCore.Mvc;
using TL.Api.Common;

namespace TL.Api.Controllers.Authentication
{
    public class UsersController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetById()
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

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}
