using System.Threading;
using System.Threading.Tasks;
using Kosmos.Application.Infrastructure;
using Kosmos.Domain.entities;
using Kosmos.Persistence.Interfaces;
using MediatR;

namespace Kosmos.Application.world.commands
{
    public sealed class CreateWorldCommandHandler : IRequestHandler<CreateWorldCommand, Result>
    {
        private readonly IWorldRepository _worldRepository;
        
        public CreateWorldCommandHandler(IWorldRepository worldRepository)
        {
            this._worldRepository = worldRepository;
        }
        
        public async Task<Result> Handle(CreateWorldCommand request, CancellationToken cancellationToken)
        {
            int worldId = await this._worldRepository.SaveAsync(request.Name, request.GameServer);

            var data = new {worlId = worldId};
            
            Result result = new Result { Success = true, Data = data};
            return  result;
        }
    }
}