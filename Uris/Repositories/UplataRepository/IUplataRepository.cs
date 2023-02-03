using Uris.Models;
using Uris.Repositories.Base;

namespace Uris.Repositories.UplataRepository
{
    public interface IUplataRepository : IBaseRepository<int, Uplata>
    {
        IEnumerable<Uplata> GetAll();
    }
}
