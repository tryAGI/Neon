
#nullable enable

namespace Neon
{
    /// <summary>
    /// Identity provider id from keycloak
    /// </summary>
    public enum IdentityProviderId
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Hasura,
        /// <summary>
        /// 
        /// </summary>
        Keycloak,
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
        /// <summary>
        /// 
        /// </summary>
        Microsoftv2,
        /// <summary>
        /// 
        /// </summary>
        Vercelmp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityProviderIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityProviderId value)
        {
            return value switch
            {
                IdentityProviderId.Github => "github",
                IdentityProviderId.Google => "google",
                IdentityProviderId.Hasura => "hasura",
                IdentityProviderId.Keycloak => "keycloak",
                IdentityProviderId.Microsoft => "microsoft",
                IdentityProviderId.Microsoftv2 => "microsoftv2",
                IdentityProviderId.Vercelmp => "vercelmp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityProviderId? ToEnum(string value)
        {
            return value switch
            {
                "github" => IdentityProviderId.Github,
                "google" => IdentityProviderId.Google,
                "hasura" => IdentityProviderId.Hasura,
                "keycloak" => IdentityProviderId.Keycloak,
                "microsoft" => IdentityProviderId.Microsoft,
                "microsoftv2" => IdentityProviderId.Microsoftv2,
                "vercelmp" => IdentityProviderId.Vercelmp,
                _ => null,
            };
        }
    }
}