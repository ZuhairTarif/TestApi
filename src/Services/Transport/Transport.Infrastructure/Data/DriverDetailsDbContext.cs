using Microsoft.EntityFrameworkCore;
using Transport.Domain.Entities;

namespace Transport.Infrastructure.Data
{
    public class DriverDetailsDbContext : DbContext
    {
        public DriverDetailsDbContext(DbContextOptions<DriverDetailsDbContext> dbContextOptions) : base(dbContextOptions) { }
        
        public DbSet<DriverDetails> Drivers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DriverDetails>().ToTable("Driver", "Transport");
        }

    }
}
