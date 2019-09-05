// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;

namespace product.Users
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
           return new ApiResource[]
            {
                new ApiResource("Administrador", "Administrador Geral"){
                    ApiSecrets = {
                        new Secret(Startup.Configuration.GetSection("keys")["ApiAdmin"].Sha256())
                    }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {                
                new Client {
                    ClientId = "Administrador",
                    ClientName = "Administrador Geral",
                    //AccessTokenLifetime = 600, // 10 minutes, default 60 minutes
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                         "Administrador"
                    },
                    ClientSecrets = {
                        new Secret(Startup.Configuration.GetSection("keys")["ClientAdmin"].Sha256())
                    }
                }
            };
        }
    }
}