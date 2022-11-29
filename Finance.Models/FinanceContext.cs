using Microsoft.EntityFrameworkCore;

namespace Finance.Models
{
    public class FinanceContext : DbContext
    {
        public DbSet<FinanceOperation> Operations { get; set; }
        public DbSet<TypeOperation> TypeOperations { get; set; }
        public FinanceContext(DbContextOptions<FinanceContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}