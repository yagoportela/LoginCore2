using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using product.Users.Models;
using product.Users.Entities.Identity;

namespace product.Users.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigureIdentityContext(builder);
        }

        private void ConfigureIdentityContext(ModelBuilder builder)
        {
            builder.Entity<UserIdentityRole>().ToTable("Roles");
            builder.Entity<UserIdentityRoleClaim>().ToTable("RoleClaims");
            builder.Entity<UserIdentityUserRole>().ToTable("UserRoles");

            builder.Entity<UserIdentity>().ToTable("Users");
            builder.Entity<UserIdentityUserLogin>().ToTable("UserLogins");
            builder.Entity<UserIdentityUserClaim>().ToTable("UserClaims");
            builder.Entity<UserIdentityUserToken>().ToTable("UserTokens");
        }
    }
}
