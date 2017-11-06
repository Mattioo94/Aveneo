using Aveneo.Models;
using Microsoft.EntityFrameworkCore;

namespace Aveneo.Persistance
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
