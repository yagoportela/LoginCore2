using System;
using IdentityServer4.EntityFramework.Interfaces;

namespace Project.IdentityServer4.Admin.EntityFramework.Identity.Interfaces
{
    [Obsolete("Implement IAdminPersistedGrantDbContext instead.")]
    public interface IAdminPersistedGrantIdentityDbContext : IPersistedGrantDbContext
    {
    }
}
