using System.Threading;
using System.Threading.Tasks;
using Kosmos.Application.Infrastructure;
using Kosmos.Domain.entities;
using MediatR;

namespace Kosmos.Application.world.commands
{
    public sealed class CreateWorldCommandHandler : IRequestHandler<CreateWorldCommand, Result>
    {
        public CreateWorldCommandHandler()
        {
            
        }
        
        public Task<Result> Handle(CreateWorldCommand request, CancellationToken cancellationToken)
        {
            World world = new World
            {
                Name = request.Name,
                GameServer = request.GameServer
            };

            //todo: persist data
            
            Result baseResult = new Result { Success = true };
            return Task.FromResult(baseResult);
        }
    }
}