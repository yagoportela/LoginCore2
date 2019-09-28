using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using Project.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> User { get; set; }
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
        }
    }
}
