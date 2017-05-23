using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Configuration.Abstractions
{
    public interface IConnectionStringManager
    {
        Task<string> GetConnectionStringAsync(string name, CancellationToken cancellationToken);
    }
}
