using Uris.Models;
using Uris.Repositories.Base;

namespace Uris.Repositories.KursRepository
{
    public interface IKursRepository : IBaseRepository<int, Kurs>
    {
        IEnumerable<Kurs> GetAll();
    }
}
