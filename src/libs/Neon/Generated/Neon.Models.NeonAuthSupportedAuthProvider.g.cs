
#nullable enable

namespace Neon
{
    /// <summary>
    /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
    /// </summary>
    public enum NeonAuthSupportedAuthProvider
    {
        /// <summary>
        ///
        /// </summary>
        BetterAuth,
        /// <summary>
        ///
        /// </summary>
        Mock,
        /// <summary>
        ///
        /// </summary>
        Stack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthSupportedAuthProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthSupportedAuthProvider value)
        {
            return value switch
            {
                NeonAuthSupportedAuthProvider.BetterAuth => "better_auth",
                NeonAuthSupportedAuthProvider.Mock => "mock",
                NeonAuthSupportedAuthProvider.Stack => "stack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthSupportedAuthProvider? ToEnum(string value)
        {
            return value switch
            {
                "better_auth" => NeonAuthSupportedAuthProvider.BetterAuth,
                "mock" => NeonAuthSupportedAuthProvider.Mock,
                "stack" => NeonAuthSupportedAuthProvider.Stack,
                _ => null,
            };
        }
    }
}