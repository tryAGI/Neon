
#nullable enable

namespace Neon
{
    /// <summary>
    /// Authentication provider for the Neon Data API. `neon_auth`: use Neon's built-in managed authentication (no JWKS configuration required). `external`: use an external JWT provider, which requires `jwks_url`. When omitted, no auth provider is configured (existing setup is kept).
    /// </summary>
    public enum DataAPICreateRequestAuthProvider
    {
        /// <summary>
        /// use Neon's built-in managed authentication (no JWKS configuration required). `external`: use an external JWT provider, which requires `jwks_url`. When omitted, no auth provider is configured (existing setup is kept).
        /// </summary>
        External,
        /// <summary>
        /// use Neon's built-in managed authentication (no JWKS configuration required). `external`: use an external JWT provider, which requires `jwks_url`. When omitted, no auth provider is configured (existing setup is kept).
        /// </summary>
        NeonAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataAPICreateRequestAuthProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataAPICreateRequestAuthProvider value)
        {
            return value switch
            {
                DataAPICreateRequestAuthProvider.External => "external",
                DataAPICreateRequestAuthProvider.NeonAuth => "neon_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataAPICreateRequestAuthProvider? ToEnum(string value)
        {
            return value switch
            {
                "external" => DataAPICreateRequestAuthProvider.External,
                "neon_auth" => DataAPICreateRequestAuthProvider.NeonAuth,
                _ => null,
            };
        }
    }
}