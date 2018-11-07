using Kosmos.Application.Infrastructure;
using MediatR;

namespace Kosmos.Application.world.commands
{
    public sealed class CreateWorldCommand : IRequest, IRequest<Result>
    {
        public string Name { get; set; }

        public string GameServer { get; set; }
    }
}