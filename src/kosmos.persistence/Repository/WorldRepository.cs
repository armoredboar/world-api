using System.Threading.Tasks;
using Kosmos.Persistence.Interfaces;

namespace Kosmos.Persistence.Repository
{
    public sealed class WorldRepository : IWorldRepository
    {
        public async Task<int> SaveAsync(string name, string gameServer) => 1;
    }
}