// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityProvider.Configuration
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "12345", Username = "shubham", Password = "shubham", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Shubham Patil"),
                    new Claim(JwtClaimTypes.Role, "User"),
                    new Claim(JwtClaimTypes.GivenName, "Shubham"),
                    new Claim(JwtClaimTypes.FamilyName, "Patil"),
                    new Claim(JwtClaimTypes.Email, "shubhampatil@gmail.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://shubhampatil.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'Street Adress', 'locality': 'Locality', 'postal_code': 480108, 'country': 'India' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "67890", Username = "sagar", Password = "sagar", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Sagar Aradwad"),
                    new Claim(JwtClaimTypes.Role, "User"),
                    new Claim(JwtClaimTypes.GivenName, "Sagar"),
                    new Claim(JwtClaimTypes.FamilyName, "Aradwad"),
                    new Claim(JwtClaimTypes.Email, "sagararadwad@gmail.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://sagararadwad.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'Street Adress', 'locality': 'Locality', 'postal_code': 480108, 'country': 'India' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json),
                    new Claim("location", "somewhere")
                }
            }
        };
    }
}