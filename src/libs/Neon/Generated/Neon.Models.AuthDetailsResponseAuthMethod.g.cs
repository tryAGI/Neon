
#nullable enable

namespace Neon
{
    /// <summary>
    /// Authentication method used for the request:<br/>
    /// - `keycloak`: Keycloak identity provider authentication.<br/>
    /// - `session_cookie`: Browser session cookie authentication.<br/>
    /// - `api_key_user`: API key scoped to a user account.<br/>
    /// - `api_key_org`: API key scoped to an organization.<br/>
    /// - `oauth`: OAuth-based authentication.
    /// </summary>
    public enum AuthDetailsResponseAuthMethod
    {
        /// <summary>
        /// API key scoped to an organization.
        /// </summary>
        ApiKeyOrg,
        /// <summary>
        /// API key scoped to a user account.
        /// </summary>
        ApiKeyUser,
        /// <summary>
        /// Keycloak identity provider authentication.
        /// </summary>
        Keycloak,
        /// <summary>
        /// OAuth-based authentication.
        /// </summary>
        Oauth,
        /// <summary>
        /// Browser session cookie authentication.
        /// </summary>
        SessionCookie,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthDetailsResponseAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthDetailsResponseAuthMethod value)
        {
            return value switch
            {
                AuthDetailsResponseAuthMethod.ApiKeyOrg => "api_key_org",
                AuthDetailsResponseAuthMethod.ApiKeyUser => "api_key_user",
                AuthDetailsResponseAuthMethod.Keycloak => "keycloak",
                AuthDetailsResponseAuthMethod.Oauth => "oauth",
                AuthDetailsResponseAuthMethod.SessionCookie => "session_cookie",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthDetailsResponseAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "api_key_org" => AuthDetailsResponseAuthMethod.ApiKeyOrg,
                "api_key_user" => AuthDetailsResponseAuthMethod.ApiKeyUser,
                "keycloak" => AuthDetailsResponseAuthMethod.Keycloak,
                "oauth" => AuthDetailsResponseAuthMethod.Oauth,
                "session_cookie" => AuthDetailsResponseAuthMethod.SessionCookie,
                _ => null,
            };
        }
    }
}