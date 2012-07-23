﻿using ThreeBytes.Core.Data.Abstract;
using ThreeBytes.User.Authentication.OAuth.Entities;
using ThreeBytes.User.Authentication.OAuth.Entities.Enums;

namespace ThreeBytes.User.Authentication.OAuth.Data.Abstract
{
    public interface IOAuthUserRepository : IKeyedGenericRepository<OAuthUser>
    {
        OAuthUser GetBy(string username, string applicationName);
        OAuthUser GetByEmail(string email, string applicationName);
        OAuthUser GetByUsernameOrEmail(string userIdentifier, string applicationName);
        OAuthUser GetByExternalAuthenticatorIdentifier(string identifier, ExternalAuthenticationType provider, string applicationName);
        bool HasRecords(string applicationName);
        bool UniqueUsername(string username, string applicationName);
        bool UniqueEmail(string email, string applicationName);
    }
}