using Uris.Context;
using Uris.Models;
using Uris.Repositories.Base;
using Uris.Repositories.KulturaRepository;

namespace Uris.Repositories.KursRepository
{
    public class KursRepository : BaseRepository<int, Kurs>, IKursRepository
    {
        private readonly UrisDbContext _context;

        public KursRepository(UrisDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Kurs> GetAll()
        {
            return _context.Kursevi.ToList();
        }
    }
}
