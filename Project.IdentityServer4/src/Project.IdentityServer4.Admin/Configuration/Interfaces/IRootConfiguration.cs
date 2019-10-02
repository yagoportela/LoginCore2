namespace Project.IdentityServer4.Admin.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        IAdminConfiguration AdminConfiguration { get; }
    }
}