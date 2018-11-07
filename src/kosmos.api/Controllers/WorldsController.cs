using System.Threading.Tasks;
using Kosmos.Application.Infrastructure;
using Kosmos.Application.world.commands;
using Microsoft.AspNetCore.Mvc;

namespace kosmos.api.Controllers
{
    public class WorldsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateWorldCommand command)
        {
            return this.Ok(await this.Mediator.Send<Result>(command));
        }
    }
}