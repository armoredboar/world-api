using System.Threading.Tasks;

namespace Kosmos.Persistence.Interfaces
{
    public interface IWorldRepository
    {
        Task<int> SaveAsync(string name, string gameServer);
    }
}