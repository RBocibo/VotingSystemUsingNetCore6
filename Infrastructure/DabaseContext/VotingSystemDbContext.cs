using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DabaseContext
{
    public class VotingSystemDbContext : DbContext
    {
        public VotingSystemDbContext(DbContextOptions<VotingSystemDbContext> options) : base(options)
        {

        }

        //Add tables here code first
    }
}
