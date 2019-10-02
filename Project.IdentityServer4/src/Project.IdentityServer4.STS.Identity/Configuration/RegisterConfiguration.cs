using Project.IdentityServer4.STS.Identity.Configuration.Intefaces;

namespace Project.IdentityServer4.STS.Identity.Configuration
{
    public class RegisterConfiguration : IRegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
    }
}
