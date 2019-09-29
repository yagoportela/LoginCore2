using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using Project.Infra.Data.Mapping;

namespace Project.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> User { get; set; }
        public DbSet<AddressEntity> Address { get; set; }
        public DbSet<CompanyEntity> Company { get; set; }
        public DbSet<CustomersEntity> Customers { get; set; }
        public DbSet<WorkshopEntity> Workshop { get; set; }
        
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<AddressEntity>(new AddressMap().Configure);
            modelBuilder.Entity<CompanyEntity>(new CompanyMap().Configure);
            modelBuilder.Entity<CustomersEntity>(new CustomersMap().Configure);
            modelBuilder.Entity<WorkshopEntity>(new WorkshopMap().Configure);
        }
    }
}
