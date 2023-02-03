using Uris.Context;
using Uris.Models;
using Uris.Repositories.Base;
using Uris.Repositories.KulturaRepository;

namespace Uris.Repositories.UplataRepository
{
    public class UplataRepository : BaseRepository<int, Uplata>, IUplataRepository
    {
        private readonly UrisDbContext _context;

        public UplataRepository(UrisDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Uplata> GetAll()
        {
            return _context.Uplate.ToList();
        }
    }
}
