using Microsoft.EntityFrameworkCore;
using Models;

namespace Kantipur.Persistence.DataContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Container> Containers { get; set; }
    }
}
