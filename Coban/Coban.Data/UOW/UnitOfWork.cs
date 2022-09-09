using Coban.Core.UnitOfWork;
using Coban.Data.Database;
using System.Threading.Tasks;

namespace Coban.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CobanDbContext _context;
        public UnitOfWork(CobanDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }


        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
