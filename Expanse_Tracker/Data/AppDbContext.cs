using Expanse_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expanse_Tracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Transaction> TblTransaction { get; set; }
        public DbSet<Category> TblCategory {get; set;}
    }
}
