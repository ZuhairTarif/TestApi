using MasterSetup.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MasterSetup.Infrastructure.Data
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> dbContextOptions) : base(dbContextOptions)
        { }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company", "MasterSetup");
        }
    }
}
