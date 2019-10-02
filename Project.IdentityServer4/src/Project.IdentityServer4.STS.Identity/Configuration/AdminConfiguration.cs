using Project.IdentityServer4.STS.Identity.Configuration.Intefaces;

namespace Project.IdentityServer4.STS.Identity.Configuration
{
    public class AdminConfiguration : IAdminConfiguration
    {
        public string IdentityAdminBaseUrl { get; set; } = "http://localhost:9000";
    }
}