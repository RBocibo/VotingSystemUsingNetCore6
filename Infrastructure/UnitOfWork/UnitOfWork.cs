using Core.UnitOfWorkInterface;
using Infrastructure.DabaseContext;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VotingSystemDbContext _context;

        public UnitOfWork(VotingSystemDbContext context)
        {
            _context = context;
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
