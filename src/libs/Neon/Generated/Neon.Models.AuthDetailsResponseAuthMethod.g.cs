
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthDetailsResponseAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyOrg,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyUser,
        /// <summary>
        /// 
        /// </summary>
        Keycloak,
        /// <summary>
        /// 
        /// </summary>
        Oauth,
        /// <summary>
        /// 
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